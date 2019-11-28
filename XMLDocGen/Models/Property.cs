using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    public class Property : Member
    {
        public string Description { get; }

        public Property(string name, string description) : base(name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Property: {base.ToString()} - summary: {Description}";
        }

        public override string ToMarkdown()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"### Property: {Name}{Environment.NewLine}");
            result.Append($"```cpp {Environment.NewLine}");
            result.Append($"property {Name};");
            result.Append($"``` {Environment.NewLine}");

            result.Append($"Description: {Description}{Environment.NewLine}");

            return result.ToString();
        }
    }
}
