using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeType : INode
    {
        public List<INode> Child { get; set; }

        public EType Type { get => EType.Type; }

        public string Name { get; }

        public string Description { get; }

        public NodeType(string name, string desc)
        {
            Name = name;
            Description = desc;
        }
    }
}
