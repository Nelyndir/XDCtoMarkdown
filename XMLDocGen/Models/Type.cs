using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    public class Type : Member
    {
        public string Description { get; }

        public Type(string name, string description) : base(name)
        {
            Description = description;
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

            return result.ToString();
        }
    }
}
