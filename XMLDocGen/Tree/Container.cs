using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace XMLDocGen
{
    public class Container 
    //class for containing and managing XML data;
    {
        protected List<XMLDocGen.Models.Member> Members { get; } 
        //Raw XML data;

        protected List<Tree.Models.INode> Nodes; 
        //Tree of sorted data;

        public Container(List<XMLDocGen.Models.Member> members)
        {
            Members = members;
            Nodes = new List<Tree.Models.INode>();
            processing();
        }

        private List<Tree.Models.INode> getNeededNode(string[] names, List<Tree.Models.INode> sNode) 
        //function for getting and creating Node whish must contain proccesing Member
        //(If inner scope is missing it creates new scope as namepace)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                if (!sNode.Exists(x => x.Name == names[i]))
                {
                    sNode.Add(new Tree.Models.NodeNamespace(names[i]));
                }
                sNode = sNode.Find(x => x.Name == names[i]).Child;
            }
            return sNode;
        }

        private void processing()
        {
            foreach (var member in Members)
            {
                List<Tree.Models.INode> Node = Nodes;
                string[] sArr = member.Name.Split("("); //in case of function with signature;
                sArr =sArr[0].Split("."); //splitting Name into scopes
                if (sArr.Length > 1)
                {
                    Node = getNeededNode(sArr, Nodes);
                }
                switch (member) 
                //Adding new Node according to its Type.
                //If Type doesn’t exist then it’s undefined.
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

        public void toMarkdownFiles(string path)
        {
            List<Tree.Models.INode> statics = new List<Tree.Models.INode>();
            var thisPathName = path;
            foreach (var child in Nodes)
            {
                switch (child.Type)
                {
                    case Tree.Models.EType.Namespace:
                        nodeParser(child, thisPathName);
                        break;
                    case Tree.Models.EType.Type:
                        saveClass(child as Tree.Models.NodeType, thisPathName);
                        break;
                    case Tree.Models.EType.Field:
                        statics.Add(child);
                        break;
                    case Tree.Models.EType.Function:
                        break;
                    case Tree.Models.EType.Property:
                        break;
                    case Tree.Models.EType.Method:
                        statics.Add(child);
                        break;
                    case Tree.Models.EType.Undefined:
                        break;
                    default:
                        break;
                }
            }
            if (statics.Count > 0)
            {
                saveStatics(statics, thisPathName, path);
            }
        }

        private void nodeParser(Tree.Models.INode node, string path)
        {
            List<Tree.Models.INode> statics = new List<Tree.Models.INode>();
            var thisPathName = Path.Combine(path, node.Name);
            foreach (var child in node.Child)
            {
                switch (child.Type)
                {
                    case Tree.Models.EType.Namespace:
                        nodeParser(child, thisPathName);
                        break;
                    case Tree.Models.EType.Type:
                        saveClass(child as Tree.Models.NodeType, thisPathName);
                        break;
                    case Tree.Models.EType.Field:
                        statics.Add(child);
                        break;
                    case Tree.Models.EType.Function:
                        break;
                    case Tree.Models.EType.Property:
                        break;
                    case Tree.Models.EType.Method:
                        statics.Add(child);
                        break;
                    case Tree.Models.EType.Undefined:
                        break;
                    default:
                        break;
                }
            }

            saveStatics(statics, thisPathName, node.Name);
        }

        private void saveClass(Tree.Models.NodeType node, string path)
        {
            Directory.CreateDirectory(path);
            string markdown = node.ToMarkdown();
            var fileName = Path.Combine(path, node.Name + ".md");

            using (var markdownFile = new StreamWriter(fileName))
            {
                markdownFile.Write(markdown);

                markdownFile.Close();
            }
        }

        private void saveStatics(List<Tree.Models.INode> statics, string path, string namespaceName)
        {
            Directory.CreateDirectory(path);
            StringBuilder data = new StringBuilder();
            foreach (var item in statics)
            {
                data.Append(item.ToMarkdown());
            }
            var fileName = Path.Combine(path, namespaceName + ".md");

            using (var markdownFile = new StreamWriter(fileName))
            {
                markdownFile.Write(data);

                markdownFile.Close();
            }
        }

    }
}