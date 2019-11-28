﻿using System;
using System.Collections.Generic;
using System.IO;
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

            var members = XDCParser.Parse(docXmlNode.SelectSingleNode("members"));

            using (var markdownFile = new StreamWriter(path + ".md"))
            {
                foreach(var member in members)
                {
                    markdownFile.Write(member.ToMarkdown());
                }

                markdownFile.Close();
            }
        
            Console.ReadKey();
        }
    }
}