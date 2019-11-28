using System;
using System.Xml;

namespace XMLDocGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input file name: ");
            //var path = Console.ReadLine();
            var path = "C:\\Users\\Nelyndir\\source\\repos\\XMLDocGen\\Natsuki Rem.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            var docXmlNode = doc.SelectSingleNode("doc");
            var assemblyNode = docXmlNode.SelectSingleNode("assembly");

            Console.WriteLine("Assembly name: " + assemblyNode.InnerText);
            foreach(XmlNode member in docXmlNode.SelectSingleNode("members").SelectNodes("member"))
            {
                var memberName = member.Attributes.GetNamedItem("name").InnerText;

                switch (memberName[0])
                {
                    case 'M':
                        {

                        }
                }
            }
            Console.ReadKey();
        }
    }
}
