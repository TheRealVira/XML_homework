using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML_GetNodeLib
{
    public static class Helper
    {
        public static IEnumerable<XElement> GetXElementsByNode(this string pathToFile, string nodeName,
            string nodeValue)
        {
            return (from node in XDocument.Load(pathToFile).Root.Elements()
                from subNode in node.Elements()
                where subNode.Name == nodeName && subNode.Value == nodeValue
                select node).ToList();
        }
    }
}