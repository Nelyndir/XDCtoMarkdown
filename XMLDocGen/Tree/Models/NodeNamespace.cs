using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeNamespace : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();
        public EType Type { get => EType.Namespace; }

        public string Name { get; }

        public NodeNamespace(string name)
        {
            Name = name;
        }
        public string ToMarkdown()
        {
            return string.Empty;
        }
    }
}
