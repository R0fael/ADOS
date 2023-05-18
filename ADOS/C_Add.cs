using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Add
{
    public class C_Add
    {
        public ConsoleColor red = ConsoleColor.Red;
        public ConsoleColor green = ConsoleColor.Green;
        public ConsoleColor blue = ConsoleColor.Blue;
        public ConsoleColor yellow = ConsoleColor.Yellow;
        public ConsoleColor black = ConsoleColor.Black;
        public ConsoleColor white = ConsoleColor.White;
        public ConsoleColor maganta = ConsoleColor.Magenta;
        public void set_color(ConsoleColor color) { System.Console.ForegroundColor = color; }
    }
}
