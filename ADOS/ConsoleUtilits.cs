using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Power = ADOS.PowerControl;

namespace ADOS
{
    public static class ConsoleUtilits
    {
        public readonly static ConsoleColor red = ConsoleColor.Red;
        public readonly static ConsoleColor green = ConsoleColor.Green;
        public readonly static ConsoleColor blue = ConsoleColor.Blue;
        public readonly static ConsoleColor yellow = ConsoleColor.Yellow;
        public readonly static ConsoleColor black = ConsoleColor.Black;
        public readonly static ConsoleColor white = ConsoleColor.White;
        public readonly static ConsoleColor maganta = ConsoleColor.Magenta;
        public readonly static ConsoleColor cyan = ConsoleColor.Cyan;
        public static void Cerror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!");
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void BSOD(String error)
        {
            Console.Clear();
            Asci.print("  ADOS  ");
            Asci.print("  CRASH ");
            Console.WriteLine(error);
            Console.ReadLine();
            Power.Reboot();
        }
        public static void Set_color(ConsoleColor color) { Console.ForegroundColor = color; }
        public static void Set_bg(ConsoleColor color) { Console.BackgroundColor = color; }
    }
}
