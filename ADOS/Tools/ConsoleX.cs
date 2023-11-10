using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Power = ADOS.Tools.PowerControl;

namespace ADOS.Tools
{
    public static class ConsoleX
    {
        public readonly static short width = 90;
        public readonly static short height = 60;
        public readonly static ConsoleColor red = ConsoleColor.Red;
        public readonly static ConsoleColor green = ConsoleColor.Green;
        public readonly static ConsoleColor blue = ConsoleColor.Blue;
        public readonly static ConsoleColor yellow = ConsoleColor.Yellow;
        public readonly static ConsoleColor black = ConsoleColor.Black;
        public readonly static ConsoleColor white = ConsoleColor.White;
        public readonly static ConsoleColor maganta = ConsoleColor.Magenta;
        public readonly static ConsoleColor cyan = ConsoleColor.Cyan;

        public const ConsoleColor defaultFoeground = ConsoleColor.Green;
        public const ConsoleColor defaultBackground = ConsoleColor.Black;
        public static void Cerror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!");
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void CriticalError(string error)
        {
            Set_bg(red);
            Console.WriteLine(error);
            Console.ResetColor();
        }
        public static void BSOD(string error)
        {
            Console.Clear();
            Asci_Art.Print("ADOS");
            Console.WriteLine();
            Asci_Art.Print("CRASH");
            Console.WriteLine();
            Console.WriteLine(error);
            Console.ReadLine();
            Power.Reboot();
        }
        public static void Set_color(ConsoleColor color) { Console.ForegroundColor = color; }
        public static void Set_bg(ConsoleColor color) { Console.BackgroundColor = color; }

        public static void Start()
        {
            Console.SetWindowSize(90, 60);
            Console.WriteLine("Console UI booted sucessfully");
        }

        public static void Print(string txt, string empty = " ", ConsoleColor topcolor = defaultFoeground, ConsoleColor dowcolor = defaultBackground)
        {
            Console.SetCursorPosition(2, Console.GetCursorPosition().Top);
            Set_color(topcolor);
            Set_bg(dowcolor);
            Console.Write(txt);
            for (int i = txt.Length; i < 90; i++)
            {
                Console.Write(empty);
            }
        }
    }
}
