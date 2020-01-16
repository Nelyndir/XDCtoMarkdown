using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeUndef : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Undefined; }

        public string Name { get; }

        public NodeUndef()
        {
            Name = "";
        }

        public NodeUndef(string name)
        {
            Name = name;
        }

        public string ToMarkdown()
        {
            return string.Empty;
        }
    }
}
