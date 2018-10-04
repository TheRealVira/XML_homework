using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBadGuys
{
    internal static class ConsoleColorHelper
    {
        internal static void ChangeColorDepeningOnGuy(this string name)
        {
            if (name.ToLower().Contains("bad"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (name.ToLower().Contains("good"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}
