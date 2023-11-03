using System;
using Sys = Cosmos.System;
using Asci = ADOS.Asci;
using Console = System.Console;
using Cosmos.System.FileSystem;

namespace ADOS
{
    public class Kernel : Sys.Kernel
    {
        private readonly static string version = "debug 2023.11.03.0";
        private readonly static ConsoleColor red = ConsoleColor.Red;
        private readonly static ConsoleColor green = ConsoleColor.Green;
        private readonly static ConsoleColor blue = ConsoleColor.Blue;
        private readonly static ConsoleColor yellow = ConsoleColor.Yellow;
        private readonly static ConsoleColor black = ConsoleColor.Black;
        private readonly static ConsoleColor white = ConsoleColor.White;
        private readonly static ConsoleColor maganta = ConsoleColor.Magenta;
        private readonly static ConsoleColor cyan = ConsoleColor.Cyan;

        private static string directory = @"0:\";

        private static CosmosVFS fs;
        protected override void BeforeRun()
        {
            fs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
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
            catch { BSOD(""); }
        }
        private static void Run_console()
        {
            Desktop();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(directory);
            Console.ResetColor();
            Console.Write(">");
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    Cerror("Command not found!");
                    break;
                case "help":
                    Set_color(red);
                    Asci.print("HELP");
                    Set_color(cyan);
                    Console.WriteLine("Power:");
                    Console.ResetColor();

                    Console.WriteLine("shutdown - shutdown");
                    Console.WriteLine("reboot - restart");

                    Set_color(cyan);
                    Console.WriteLine("File System controll:");
                    Console.ResetColor();
                    break;
                case "reboot":
                    Reboot();
                    break;
                case "shutdown":
                    Shutdown();
                    break;
                case "bsod":
                    BSOD("Manual crash");
                    break;
                case "mkfile":
                    Console.WriteLine("name:");
                    fs.CreateFile(directory+Console.ReadLine());
                    break;
                case "mkdir":
                    Console.WriteLine("name:");
                    fs.CreateDirectory(directory + Console.ReadLine());
                    break;
                case "delfile":
                    Console.WriteLine("name:");
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(directory + Console.ReadLine());
                    break;
                case "deldir":
                    Console.WriteLine("name:");
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(directory + Console.ReadLine());
                    break;
                case "cd":
                    directory = Console.ReadLine();
                    break;
                case "dir":
                    try
                    {
                        var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directory);
                        foreach (var directoryEntry in directory_list)
                        {
                            try
                            {
                                var entry_type = directoryEntry.mEntryType;
                                if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("|file|      " + directoryEntry.mName);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("|directory| " + directoryEntry.mName);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: Directory not found");
                                Console.WriteLine(e.ToString());
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case "about":
                    Console.Clear();

                    Set_bg(maganta);
                    Asci.print("ADOS");
                    Console.WriteLine("an open source DOS");
                    Console.WriteLine(version);
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
            }

            Console.ReadLine();
        }

        private static void Cerror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!");
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void BSOD(String error)
        {
            Console.Clear();
            Asci.print("  ADOS  ");
            Asci.print("  CRASH ");
            Console.WriteLine(error);
            Console.ReadLine();
            Reboot();
        }
        private static void Set_color(ConsoleColor color) { Console.ForegroundColor = color; }
        private static void Set_bg(ConsoleColor color) { Console.BackgroundColor = color; }

        private static void Shutdown()
        {
            Sys.Power.Shutdown();
            Console.WriteLine("It's now save to turn off virtual machine");
        }

        private static void Reboot()
        {
            Sys.Power.Reboot();
            Console.WriteLine("It's now save to reboot virtual machine");
        }

        private static void Desktop()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
            Set_color(ConsoleColor.Green);
            Console.WriteLine(directory);
            try
            {
                var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directory);
                foreach (var directoryEntry in directory_list)
                {
                    try
                    {
                        var entry_type = directoryEntry.mEntryType;
                        if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("|file|      " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("|directory| " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: Directory not found");
                        Console.WriteLine(e.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
