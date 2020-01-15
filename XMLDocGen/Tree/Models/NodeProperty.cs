using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeProperty : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Property; }

        public string Name { get; }

        public string Description { get; }

        public NodeProperty(string name, string desc)
        {
            Name = name;
            Description = desc;
        }
    }
}
