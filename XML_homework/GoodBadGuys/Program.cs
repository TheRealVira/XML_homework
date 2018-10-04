using System;
using System.Xml.Linq;

namespace GoodBadGuys
{
    internal class Program
    {
        private static readonly string GoodGuyBadGuy = "GoodGuyBadGuy.xml";

        private static void Main(string[] args)
        {
            foreach (var node in XDocument.Load(GoodGuyBadGuy).Root.Elements())
            {
                node.Name.ToString().ChangeColorDepeningOnGuy();
                Console.WriteLine(node.Name);
                foreach (var subnode in node.Elements())
                {
                    Console.Write($"\t{subnode.Name}: {subnode.Value} ");
                    if (subnode.HasAttributes)
                        Console.Write($"{subnode.Attribute("Port").Name}: \"{subnode.Attribute("Port").Value}\"");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        
    }
}