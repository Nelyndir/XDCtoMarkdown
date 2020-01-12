using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeFunction : INode
    {
        public List<INode> Child { get; set; }

        public EType Type { get => EType.Function; }

        public string Name { get; }

        public string Description { get; }

        public UInt16 Args { get; }

        public string Returning { get; }

        public NodeFunction(string name, string desc, UInt16 args, string ret)
        {
            Name = name;
            Description = desc;
            Args = args;
            Returning = ret;
        }
    }
}
