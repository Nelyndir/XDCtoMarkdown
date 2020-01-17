using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    class NodeFunction : INode
    {
        public List<INode> Child { get; set; } = new List<INode>();

        public EType Type { get => EType.Function; }

        public string Name { get; }

        public string Description { get; }

        Dictionary<string, string> Args { get; }

        public string Returning { get; }
        public string FullName { get; }
        public NodeFunction(string name, string desc, Dictionary<string, string> args, string ret, string fn)
        {
            Name = name;
            Description = desc;
            Args = args;
            Returning = ret;
            FullName = fn;
        }
    }
}
