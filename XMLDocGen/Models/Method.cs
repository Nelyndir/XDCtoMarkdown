using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    class Method : Member
    {
        public string Description { get; }
        public string Returns { get; }
        public Dictionary<string, string> Args { get; }

        public Method(string name, string description, string returns, Dictionary<string, string> args)
            : base(name)
        {
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
    }
}
