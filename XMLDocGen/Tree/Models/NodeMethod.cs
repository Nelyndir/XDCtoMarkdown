using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeMethod : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Method; }

        public string Name { get; }

        public string Description { get; }

        public UInt16 Args { get; }

        public string Returning { get; }
        
        public NodeMethod(string name, string desc, UInt16 args,string ret)
        {
            Name = name;
            Description = desc;
            Args = args;
            Returning = ret;
        }
    }
}
