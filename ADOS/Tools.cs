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
        public readonly static string version = "debug 2023.11.07.0";

        public static void About()
        {
            Console.Clear();
            Asci_Art.Print("ADOS");
            ConsoleX.Print("an open source DOS");
            ConsoleX.Print("made by R0fael");
            ConsoleX.Print("Version:");
            ConsoleX.Print(version);
            ConsoleX.Print("");
            ConsoleX.Print("");
        }

        public static void Help()
        {
            ConsoleX.Set_color(ConsoleX.red);
            Asci_Art.Print("HELP");
            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("Power:");
            Console.ResetColor();

            ConsoleX.Print("shutdown - shutdown");
            ConsoleX.Print("reboot - restart");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("File System controll:");
            Console.ResetColor();

            ConsoleX.Print("mkfile - makes a file");
            ConsoleX.Print("mkdir - makes dir");
            ConsoleX.Print("delfile - delets file");
            ConsoleX.Print("deldir - delets directory");

            ConsoleX.Print("cd - changes local path");
            ConsoleX.Print("cdf - changes global path");

            Console.WriteLine("movfile - moves file");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("Internet:");
            Console.ResetColor();
            ConsoleX.Print("ip - gets current ip adress");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("Test Functions:");
            Console.ResetColor();
            ConsoleX.Print("bsod - call Blacl Screen Of Death");
            ConsoleX.Print("asci - write big letters that made from asci symbols");

            ConsoleX.Set_color(ConsoleX.cyan);
            ConsoleX.Print("System Functions:");
            Console.ResetColor();
            ConsoleX.Print("about - gets the version and info about OS");
            ConsoleX.Print("time - gets time and date");
            ConsoleX.Print("gosl - get potentional list of OSes that may installed on this PC");
        }
    }
}
