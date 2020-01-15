using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLDocGen
{
    public class XDCParser
    {
        public static List<Models.Member> Parse(XmlNode xmlMembers)
        {
            var members = new List<Models.Member>();

            foreach (XmlNode member in xmlMembers.SelectNodes("member"))
            {
                var memberName = member.Attributes.GetNamedItem("name").InnerText;

                switch (memberName[0])
                {
                    case 'M':
                        {
                            ParseMethod(members, member, memberName);
                            break;
                        }
                    case 'P':
                        {
                            ParseProperty(members, member, memberName);
                            break;
                        }
                    case 'T':
                        {
                            ParseType(members, member, memberName);
                            break;
                        }
                    case 'F':
                        {
                            ParseField(members, member, memberName);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid type of member: {memberName}");
                            break;
                        }
                }
            }

            return members;
        }

        private static void ParseField(List<Models.Member> members, XmlNode member, string memberName)
        {
            var name = String.Empty;
            var summary = String.Empty;
            name = memberName.Substring(2);
            try
            {
                summary = member.SelectSingleNode("summary").InnerText;
            }
            catch (System.Xml.XPath.XPathException) { }
            catch (NullReferenceException) { }
            members.Add(new Models.Field(name, summary));
        }

        private static void ParseType(List<Models.Member> members, XmlNode member, string memberName)
        {
            var name = String.Empty;
            var summary = String.Empty;
            name = memberName.Substring(2);
            try
            {
                summary = member.SelectSingleNode("summary").InnerText;
            }
            catch (System.Xml.XPath.XPathException) { }
            catch (NullReferenceException) { }
            members.Add(new Models.Type(name, summary));
        }

        private static void ParseProperty(List<Models.Member> members, XmlNode member, string memberName)
        {
            var name = String.Empty;
            var summary = String.Empty;
            name = memberName.Substring(2);
            try
            {
                summary = member.SelectSingleNode("summary").InnerText;
            }
            catch (System.Xml.XPath.XPathException) { }
            catch (NullReferenceException) { }
            members.Add(new Models.Property(name, summary));
        }

        private static void ParseMethod(List<Models.Member> members, XmlNode member, string memberName)
        {
            var name = String.Empty;
            var summary = String.Empty;
            var returns = String.Empty;
            var param = new Dictionary<string, string>();
            name = memberName.Substring(2);
            try
            {
                summary = member.SelectSingleNode("summary").InnerText;
            }
            catch (System.Xml.XPath.XPathException) { }
            catch (NullReferenceException) { }
            try
            {
                returns = member.SelectSingleNode("returns").InnerText;
            }
            catch (System.Xml.XPath.XPathException) { }
            catch (NullReferenceException) { }
            foreach (XmlNode paramXML in member.SelectNodes("param"))
            {
                try
                {
                    param.Add(paramXML.Attributes.GetNamedItem("name").InnerText, paramXML.InnerText);
                }
                catch (NullReferenceException) { }
            }

            members.Add(new Models.Method(name, summary, returns, param));
        }
    }
}
