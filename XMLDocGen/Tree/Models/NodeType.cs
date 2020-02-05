using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeType : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Type; }

        public string Name { get; }

        public string Description { get; }

        public Dictionary<string, string> Args { get; }

        public string FullName { get; }
        public NodeType(string name, string desc, Dictionary<string, string> args, string fn)
        {
            Name = name;
            Description = desc;
            FullName = fn;
            Args = args;
        }
        public string ToMarkdown()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"### class\\struct {Name}{Environment.NewLine}");
            result.Append($"```cpp {Environment.NewLine}");
            result.Append($"class {Name};");
            result.Append($"{Environment.NewLine} ``` {Environment.NewLine}");

            result.Append($"Description: {Description}{Environment.NewLine}");

            foreach (var child in Child)
            {
                result.Append(child.ToMarkdown());
            }

            return result.ToString();
        }
    }
}
