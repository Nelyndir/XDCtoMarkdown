using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen
{
    public class Container
    {
        protected List<XMLDocGen.Models.Member> Members { get; }

        protected List<Tree.Models.INode> Nodes;

        public Container (List<XMLDocGen.Models.Member> members)
        {
            Members = members;
        }

        private bool isExistNode(string name, List<Tree.Models.INode> sNode)
        {
            try {
                sNode.Find(x => x.Name == name); 
            }
            catch (ArgumentNullException){
                return false;
            }
            return true;
        }

        private void processing()
        {
            foreach (var member in Members)
            {
                string[] sArr = member.Name.Split(".");
                List<Tree.Models.INode> sNode = Nodes;
                for (int i = 0; i < sArr.Length - 1; i++)
                {
                    sNode.Find(x => x.Name == sArr[i]);
                }
                switch (member)
                {
                    case Models.Field fld:
                        break;
                }
            }
        }

    }
}