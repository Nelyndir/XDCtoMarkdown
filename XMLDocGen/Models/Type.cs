using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    public class Type : Member
    {
        public string Description { get; }
        public Dictionary<string, string> Args { get; }

        public Type(string name, string description, Dictionary<string, string> args) : base(name)
        {
            Description = description;
            Args = args;
        }

        public override string ToString()
        {
            return $"Type: {base.ToString()} - summary: {Description}";
        }

        public override string ToMarkdown()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"### class\\struct {Name}{Environment.NewLine}");
            result.Append($"```cpp {Environment.NewLine}");
            result.Append($"class {Name};");
            result.Append($"{Environment.NewLine} ``` {Environment.NewLine}");

            result.Append($"Description: {Description}{Environment.NewLine}");

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
