using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLDocGen.Models
{
    public class Method : Member
    {
        private static Dictionary<string, string> nameReplaceTable = new Dictionary<string, string>
        {
            {"op_Subscript", "operator[]" },
            {"#ctor", "ctor" },
            {"<unknown type>", "implementation specific" },
            {"op_Implicit~", "operator " },
            {"op_Decrement", "--" },
            {"=FUNC:", "FunctionPtr:" }
        };

        public string Description { get; }
        public string Returns { get; }
        public Dictionary<string, string> Args { get; }

        public Method(string name, string description, string returns, Dictionary<string, string> args)
            : base(name)
        {
            MethodParser(); 

            Description = description;
            Returns = returns;
            Args = args;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder($"Method: {base.ToString()}");
            result.Append($" - summary: {Description}{Environment.NewLine}");
            result.Append($" - return: {Returns}{Environment.NewLine}");
            foreach (var param in Args)
            {
                result.Append($" - arg {param.Key} : {param.Value}{Environment.NewLine}");
            }
            return result.ToString();
        }

        private void MethodParser()
        {
            if (Name.IndexOf('(') == -1)
            {
                Name = Name + "()";
                return;
            }

            foreach(var replaceItem in nameReplaceTable)
            {
                Name = Name.Replace(replaceItem.Key, replaceItem.Value);
            }

            var methodArgs = Name.Substring(Name.IndexOf('(') + 1, Name.IndexOf(')') - Name.IndexOf('(') - 1);
            var methodArg = methodArgs.Split(',');
            string parsedMethodName = Name.Substring(0, Name.IndexOf('(') + 1);
            foreach (var arg in methodArg)
            {
                List<string> argPart = new List<string>(arg.Split('!'));

                switch (argPart.Count)
                {
                    case 1:
                        {
                            parsedMethodName += ($"{argPart[0]}, ");
                            continue;
                        }
                    case 2:
                        {
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsImplicitlyDereferenced"))
                            {
                                if (argPart[0].Last() == '*')
                                {
                                    parsedMethodName += argPart[0].Substring(0, argPart[0].Length - 1) + "&, ";
                                }
                                else
                                {
                                    parsedMethodName += ($"{argPart[0]}&, ");
                                }
                                continue;
                            }
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsConst*"))
                            {
                                parsedMethodName += ($"const {argPart[0]} *, ");
                                continue;
                            }
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsVolatile*"))
                            {
                                parsedMethodName += ($"volatile {argPart[0]} *, ");
                                continue;
                            }
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsConst"))
                            {
                                parsedMethodName += ($"const {argPart[0]}");
                                continue;
                            }
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsVolatile"))
                            {
                                parsedMethodName += ($"const {argPart[0]}");
                                continue;
                            }
                            continue;
                        }
                    case 3:
                        {
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsConst*"))
                            {
                                if (argPart[2].Contains("System.Runtime.CompilerServices.IsImplicitlyDereferenced"))
                                    parsedMethodName += ($"const {argPart[0]} &, ");
                                continue;
                            }
                            if (argPart[1].Contains("System.Runtime.CompilerServices.IsVolatile*"))
                            {
                                if (argPart[2].Contains("System.Runtime.CompilerServices.IsImplicitlyDereferenced"))
                                    parsedMethodName += ($"volatile {argPart[0]} &, ");
                                continue;
                            }
                            continue;
                        }
                    default:
                        {
                            parsedMethodName += ($"{argPart[0]}, ");
                            continue;
                        }
                }
            }

            Name = parsedMethodName.Substring(0, parsedMethodName.Length - 2) + ")";
        }

        public override string ToMarkdown()
        {
            StringBuilder result = new StringBuilder();

            if(Name.IndexOf('(') == -1)
                result.Append($"### Method {Name}{Environment.NewLine}");
            else
                result.Append($"### Method {Name.Substring(0, Name.IndexOf('('))}{Environment.NewLine}");

            result.Append($"```cpp {Environment.NewLine}");
            result.Append(Name);
            result.Append($"``` {Environment.NewLine}");

            result.Append($"Description: {Description}{Environment.NewLine}");
            result.Append($"Returns: {Returns}{Environment.NewLine}");

            result.Append($"Parameters: {Environment.NewLine}");

            result.Append($"_____ {Environment.NewLine}");
            foreach (var param in Args)
            {
                result.Append($"1. {param.Key} - {param.Value}{Environment.NewLine}");
            }
            result.Append($"_____ {Environment.NewLine}");

            return result.ToString();
        }
    }
}
