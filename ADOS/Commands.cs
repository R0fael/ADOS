using System;
using Sys = Cosmos.System;
using Asci = ADOS.Tools.Asci_Art;
using Console = System.Console;
using Cosmos.System.FileSystem;
using System.IO;
using System.Runtime.Versioning;
using FileSystem = ADOS.FileSystem;
using Power = ADOS.Tools.PowerControl;
using ConsoleX = ADOS.Tools.ConsoleX;
using Cosmos.System;
using Web = ADOS.Tools.Web;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.Config;
using Getos = ADOS.GetOSes;
using Engine2d = ADOS.Things.Engine2D;
using System.Numerics;
using System.Threading;
using ADOS.Tools;

namespace ADOS
{
    public static class Commands {


    public static void Desktop()
    {
        Console.SetCursorPosition(0, 0);
        ConsoleX.Print("");
        ConsoleX.Set_color(ConsoleColor.Green);
        ConsoleX.Print(FileSystem.directory);
        FileSystem.Dir();
    }

    public static void Run(string input)
    {
        switch (input)
        {
            default:
                ConsoleX.Cerror("Command not found!");
                break;
            case "help":
                Tools.Tools.Help();
                break;
            case "reboot":
                Power.Reboot();
                break;
            case "shutdown":
                Power.Shutdown();
                break;
            case "bsod":
                ConsoleX.BSOD("Manual crash");
                break;

            case "mkfile":
                ConsoleX.Print("name:");
                FileSystem.CreateFile(Console.ReadLine());
                break;
            case "mkdir":
                ConsoleX.Print("name:");
                FileSystem.CreateDir(Console.ReadLine());
                break;
            case "delfile":
                ConsoleX.Print("name:");
                FileSystem.DeleteFile(Console.ReadLine());
                break;
            case "deldir":
                ConsoleX.Print("name:");
                FileSystem.DeleteDir(Console.ReadLine());
                break;
            case "cd":
                FileSystem.directory += Console.ReadLine();
                break;
            case "cdf":
                FileSystem.directory = Console.ReadLine();
                break;
            case "dir":
                FileSystem.Dir();
                break;
            case "about":
                Tools.Tools.About();
                break;

            case "readfile":
                Console.Write(FileSystem.ReadFile(Console.ReadLine()));
                Console.WriteLine();
                break;
            case "rewritefile":
                FileSystem.WriteFile(Console.ReadLine(), Console.ReadLine());
                break;

            case "movfile":
                FileSystem.MoveFile(FileSystem.directory + Console.ReadLine(), Console.ReadLine());
                break;

            /*case "movdir":
                FileSystem.MoveDir(FileSystem.directory + Console.ReadLine(), Console.ReadLine());
                break;*/
            case "getinfo":
                FileSystem.Info(Console.ReadLine());
                break;
            case "echo":
                ConsoleX.Print(Console.ReadLine());
                break;
            case "asci":
                Asci_Art.Print(Console.ReadLine(), Console.ReadLine().ToCharArray()[0]);
                break;
            case "ip":
                ConsoleX.Print(NetworkConfiguration.CurrentAddress.ToString());
                break;
            case "":
                Desktop();
                break;
            case "time":
                ConsoleX.Print(DateTime.Now.ToString());
                break;
            case "gosl":
                Getos.GetList();
                break;
            case "square":
                    Engine2d.DrawSquare(new Vector2(0, 0), new Vector2(10, 10),'@');
                    break;
            case "line":
                Engine2d.DrawLine(new Vector2(0, 0), new Vector2(10, 10), '@');
                break;
            case "triangle":
                Vector2[] triangle = {new Vector2(0,0),new Vector2(10,10),new Vector2(0,10)};
                Engine2d.DrawPolygon(triangle,'@') ;
                break;
            case "polygon":
                Vector2[] polygon = { new Vector2(0, 0), new Vector2(0, 10), new Vector2(5, 10), new Vector2(5, 10), new Vector2(5, 5), new Vector2(5, 0)};
                Engine2d.DrawPolygon(polygon, '@');
                break;
            }
            Console.ReadLine();
        }
    }
}
