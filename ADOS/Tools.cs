using Cosmos.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;
using ConsoleX = ADOS.ConsoleUtilits;

namespace ADOS
{
    public static class Tools
    {
        public readonly static string version = "debug 2023.11.03.0";

        public static void About()
        {
            Console.Clear();
            ConsoleX.Set_bg(ConsoleX.maganta);
            Asci.print("ADOS");
            Console.WriteLine("an open source DOS");
            Console.WriteLine(version);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Help()
        {
            ConsoleX.Set_color(ConsoleX.red);
            Asci.print("HELP");
            ConsoleX.Set_color(ConsoleX.cyan);
            Console.WriteLine("Power:");
            Console.ResetColor();

            Console.WriteLine("shutdown - shutdown");
            Console.WriteLine("reboot - restart");

            ConsoleX.Set_color(ConsoleX.cyan);
            Console.WriteLine("File System controll:");
            Console.ResetColor();

            Console.WriteLine("mkfile - makes a file");
            Console.WriteLine("mkdir - makes dir");
            Console.WriteLine("delfile - delets file");
            Console.WriteLine("deldir - delets directory");

            Console.WriteLine("cd - changes local path");
            Console.WriteLine("cdf - changes global path");

            Console.WriteLine("movfile - moves file");
        }
    }
}
