using System;
using Sys = Cosmos.System;
using Asci = ADOS.Asci_Art;
using Console = System.Console;
using Cosmos.System.FileSystem;
using System.IO;
using System.Runtime.Versioning;
using FileSystem = ADOS.FileSystem;
using Power = ADOS.PowerControl;
using ConsoleX = ADOS.ConsoleUtilits;
using Cosmos.System;
using Web = ADOS.Web;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.Config;
using Commands = ADOS.Commands;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ADOS
{
    public class CLI
    {
        public static int x = 0;
        public static int y = 0;
        public static int x_old = 0;
        public static int y_old = 0;
        public static void WriteEdge(int length)
        {
            Console.Write("+");
            for(int i = 0; i < length; i++) {
                Console.Write(" ");
            }
            Console.Write("+");
        }
        public static void Update()
        {
            ConsoleX.Set_color(ConsoleX.green);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("| command in |");
            Console.WriteLine("| time: "+DateTime.Now+" |");
            KeyUpdate();
            if (x < 0)
            {
                x = 0;
            }
            if (x > 88)
            {
                x = 88;
            }
            if(y < 0)
            {
                y = 0;
            }
            if(y > 59) {
                y = 59;
            }
            Console.SetCursorPosition(x_old, y_old);
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write('^');
            x_old = x;
            y_old = y;
        }
        static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

        }

        private static void KeyUpdate()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    y += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    x -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    x += 1;
                    break;
                case ConsoleKey.LeftWindows:
                    Console.SetCursorPosition(15, 0);
                    Commands.commands(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.Delete:
                    Console.Write(" ");
                    Commands.commands(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.Backspace:
                    Console.Write(" ");
                    Commands.commands(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
