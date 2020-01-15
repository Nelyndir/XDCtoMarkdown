using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen
{
    public class Container
    {
        protected List<XMLDocGen.Models.Member> Members { get; }

        protected List<Tree.Models.INode> Nodes;

        public Container(List<XMLDocGen.Models.Member> members)
        {
            Members = members;
            Nodes = new List<Tree.Models.INode>();
            processing();
        }

        private List<Tree.Models.INode> getNeededNode(string[] names, List<Tree.Models.INode> sNode)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                if (sNode.Find(x => x.Name == names[i]) == null)
                {
                    sNode.Add(new Tree.Models.NodeNamespace(names[i]));
                }
                sNode = sNode.Find(x => x.Name == names[i]).Child;
                i++;
            }
            return sNode;
        }

        private void processing()
        {
            foreach (var member in Members)
            {
                List<Tree.Models.INode> Node = Nodes;
                string[] sArr = member.Name.Split("(");
                sArr =sArr[0].Split(".");
                if (sArr.Length > 1)
                {
                    Node = getNeededNode(sArr, Nodes);
                }
                switch (member)
                {
                    case Models.Field fld:
                        Node.Add(new Tree.Models.NodeField(sArr[sArr.Length - 1], fld.Description));
                        break;
                    case Models.Method mth:
                        Node.Add(new Tree.Models.NodeMethod(sArr[sArr.Length - 1], mth.Description, mth.Args, mth.Returns));
                        break;
                    case Models.Property prt:
                        Node.Add(new Tree.Models.NodeProperty(sArr[sArr.Length - 1], prt.Description));
                        break;
                    case Models.Type tp:
                        Node.Add(new Tree.Models.NodeType(sArr[sArr.Length - 1], tp.Description));
                        break;
                    default:
                        Node.Add(new Tree.Models.NodeUndef(sArr[sArr.Length - 1]));
                        break;
                }
            }
        }

    }
}