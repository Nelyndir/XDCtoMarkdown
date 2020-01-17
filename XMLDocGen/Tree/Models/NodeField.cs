using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeField : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Field; }

        public string Name { get; }

        public string Description { get; }

        public string FullName { get; }

        public NodeField(string name, string desc, string fn)
        {
            Name = name;
            Description = desc;
            FullName = fn;
        }
    }
}
