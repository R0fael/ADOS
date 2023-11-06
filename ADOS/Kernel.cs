using System;
using Sys = Cosmos.System;
using Asci = ADOS.Asci;
using Console = System.Console;
using Cosmos.System.FileSystem;
using System.IO;
using System.Runtime.Versioning;
using FileSystem = ADOS.FileSystem;
using Power = ADOS.PowerControl;
using ConsoleX = ADOS.ConsoleUtilits;
using Cosmos.System;

namespace ADOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            //Console.SetWindowSize(90, 60);
            FileSystem.fs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(FileSystem.fs);
            Console.Clear();

            Asci.print("ADOS");
            Console.WriteLine("an open source DOS");

            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        protected override void Run()
        {
            try
            {
                Run_console();
            }
            catch (Exception e) { ConsoleX.BSOD(e.ToString()); }
        }
        private void Run_console()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(FileSystem.directory);
            Console.ResetColor();
            Console.Write(">");
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    ConsoleX.Cerror("Command not found!");
                    break;
                case "help":

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
                    Console.WriteLine("name:");
                    FileSystem.CreateFile(Console.ReadLine());
                    break;
                case "mkdir":
                    Console.WriteLine("name:");
                    FileSystem.CreateDir(Console.ReadLine());
                    break;
                case "delfile":
                    Console.WriteLine("name:");
                    FileSystem.DeleteFile(Console.ReadLine());
                    break;
                case "deldir":
                    Console.WriteLine("name:");
                    FileSystem.DeleteDir(Console.ReadLine());
                    break;
                case "cd":
                    FileSystem.directory+= Console.ReadLine();
                    break;
                case "cdf":
                    FileSystem.directory = Console.ReadLine();
                    break;
                case "dir":

                    break;
                case "about":
                    Tools.About();
                    break;
                
                case "readfile":
                    Console.Write(FileSystem.ReadFile(Console.ReadLine()));
                    Console.WriteLine();
                    break;
                case "rewritefile":
                    FileSystem.WriteFile(Console.ReadLine(),Console.ReadLine());
                    break;
                
                case "movfile":
                    FileSystem.MoveFile(FileSystem.directory + Console.ReadLine(), Console.ReadLine());
                    break;
                /*
                case "movdir":
                    FileSystem.MoveDir(directory + Console.ReadLine(), Console.ReadLine());
                    break;*/
                case "getinfo":
                    FileSystem.Info(Console.ReadLine());
                    break;
                case "echo":
                    Console.WriteLine(Console.ReadLine());
                    break;
                case "asci":
                    Asci.print(Console.ReadLine());
                    break;
                case "":
                    Desktop();
                    break;
            }
        }

        private static void Desktop()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
            ConsoleX.Set_color(ConsoleColor.Green);
            Console.WriteLine(FileSystem.directory);
            FileSystem.Dir();
        }
    }
}
