using Cosmos.System;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using C_Add;

namespace ADOS
{
    public class Kernel : Sys.Kernel
    {
        String now_logged = "";
        String directory = "";
        protected override void BeforeRun()
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Red; System.Console.Write("AAAA"); System.Console.ForegroundColor = ConsoleColor.Green; System.Console.Write("      "); System.Console.ForegroundColor = ConsoleColor.Blue; System.Console.Write("  DDD "); System.Console.ForegroundColor = ConsoleColor.Yellow; System.Console.Write("  OOOO"); System.Console.ForegroundColor = ConsoleColor.Magenta; System.Console.WriteLine("  SSSS");
            System.Console.ForegroundColor = ConsoleColor.Red; System.Console.Write("A  A"); System.Console.ForegroundColor = ConsoleColor.Green; System.Console.Write("      "); System.Console.ForegroundColor = ConsoleColor.Blue; System.Console.Write("  D  D"); System.Console.ForegroundColor = ConsoleColor.Yellow; System.Console.Write("  O  O"); System.Console.ForegroundColor = ConsoleColor.Magenta; System.Console.WriteLine("  S   ");
            System.Console.ForegroundColor = ConsoleColor.Red; System.Console.Write("AAAA"); System.Console.ForegroundColor = ConsoleColor.Green; System.Console.Write(" -----"); System.Console.ForegroundColor = ConsoleColor.Blue; System.Console.Write("  D  D"); System.Console.ForegroundColor = ConsoleColor.Yellow; System.Console.Write("  O  O"); System.Console.ForegroundColor = ConsoleColor.Magenta; System.Console.WriteLine("   SSS");
            System.Console.ForegroundColor = ConsoleColor.Red; System.Console.Write("A  A"); System.Console.ForegroundColor = ConsoleColor.Green; System.Console.Write("      "); System.Console.ForegroundColor = ConsoleColor.Blue; System.Console.Write("  D  D"); System.Console.ForegroundColor = ConsoleColor.Yellow; System.Console.Write("  O  O"); System.Console.ForegroundColor = ConsoleColor.Magenta; System.Console.WriteLine("     S");
            System.Console.ForegroundColor = ConsoleColor.Red; System.Console.Write("A  A"); System.Console.ForegroundColor = ConsoleColor.Green; System.Console.Write("      "); System.Console.ForegroundColor = ConsoleColor.Blue; System.Console.Write("  DDD "); System.Console.ForegroundColor = ConsoleColor.Yellow; System.Console.Write("  OOOO"); System.Console.ForegroundColor = ConsoleColor.Magenta; System.Console.WriteLine("  SSS ");

            System.Console.ResetColor();
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }

        protected override void Run()
        {
            run_console(directory);
        }
        public void run_console(String directory)
        {
            switch (now_logged)
            {
                default:
                    //System.Console.Clear();
                    System.Console.Write("Login: ");
                    var login = System.Console.ReadLine();
                    System.Console.Write("password: ");
                    var password = System.Console.ReadLine();
                    switch (login)
                    {
                        default:
                            cerror("User not found!");
                            break;
                        case "roma":
                            if (password == "1234")
                            {
                                now_logged = "roma";
                                System.Console.Clear();
                                System.Console.WriteLine("Welcome," + now_logged);
                            }
                            else
                            {
                                cerror("Wrong password!");
                            }
                            break;
                    }
                    break;
                case "roma":
                    System.Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.Write(directory);
                    System.Console.ResetColor();
                    System.Console.Write(">");
                    var input = System.Console.ReadLine();
                    switch (input)
                    {
                        default:
                            cerror("Command not found!");
                            break;
                        case "help":
                            System.Console.WriteLine("Power:");
                            System.Console.WriteLine("shutdown - shutdown");
                            System.Console.WriteLine("reboot - restart");
                            System.Console.WriteLine("logout - logout");
                            System.Console.WriteLine("User controll:");
                            System.Console.WriteLine("whoami - user where you are");
                            break;
                        case "reboot":
                            Sys.Power.Reboot();
                            break;
                        case "shutdown":
                            Sys.Power.Shutdown();
                            break;
                        case "logout":
                            now_logged = "";
                            System.Console.Clear();
                            break;
                        case "whoami":
                            System.Console.WriteLine(now_logged);
                            break;
                    }
                    break;
            }

        }

        public void cerror(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Error!");
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }
    }
}
