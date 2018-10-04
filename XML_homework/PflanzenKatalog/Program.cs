using System;
using System.Linq;
using XML_GetNodeLib;

namespace PflanzenKatalog
{
    internal class Program
    {
        private static readonly string PflanzenSource = "../PflanzenKatalog.xml";

        private static void Main(string[] args)
        {
            PflanzenSource.GetXElementsByNode("Light".ToUpper(), "Shade").ToList().ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}