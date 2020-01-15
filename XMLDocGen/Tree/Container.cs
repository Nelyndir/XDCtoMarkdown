using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen
{
    public class Container
    {
        protected List<XMLDocGen.Models.Member> Members { get; }

        //protected List<Tree.Models.INode> Nodes { get; set; } = new List<Tree.Models.INode>();

        public Container (List<XMLDocGen.Models.Member> members)
        {
            Members = members;
            Console.ReadKey();
        }
    }
}