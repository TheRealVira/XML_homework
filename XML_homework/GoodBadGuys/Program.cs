using System;
using System.Xml.Linq;

namespace GoodBadGuys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatXml(@"GoodGuyBadGuy.xml"));
            Console.ReadKey();
        }

        private static string FormatXml(string xmlFile) => XDocument.Parse(xmlFile).ToString();
    }
}
