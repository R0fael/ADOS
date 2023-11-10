using System;
using System.Numerics;
using Console = System.Console;
using ConsoleX = ADOS.Tools.ConsoleX;

namespace ADOS.Things
{
    public class CLI
    {
        private static int XCursor = 0;
        private static int YCursor = 0;
        private static int OLD_XCursor = 0;
        private static int OLD_YCursor = 0;
        public static void WriteEdge(int length)
        {
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
            }
            Console.Write("+");
        }
        public static void Update()
        {
            ConsoleX.Set_color(ConsoleX.green);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("| command in |");
            Console.WriteLine("| time: " + DateTime.Now + " |");
            Console.WriteLine($"| ADOS version {Tools.Tools.version} |");
            if (Console.KeyAvailable)
            {
                KeyUpdate();
                if (XCursor < 0) { XCursor = 88; }
                if (XCursor > 88) { XCursor = 0; }
                if (YCursor < 0) { YCursor = 59; }
                if (YCursor > 59) { YCursor = 0; }
                Console.SetCursorPosition(OLD_XCursor, OLD_YCursor);
                Console.Write(' ');
                Console.SetCursorPosition(XCursor, YCursor);
                Console.Write('o');
                OLD_XCursor = XCursor;
                OLD_YCursor = YCursor;
            }
        }

        private static void KeyUpdate()
        {
            int cursor_speed = 1;
            ConsoleKeyInfo info = Console.ReadKey();
            ConsoleKey key = info.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    YCursor -= cursor_speed;
                    break;
                case ConsoleKey.DownArrow:
                    YCursor += cursor_speed;
                    break;
                case ConsoleKey.LeftArrow:
                    XCursor -= cursor_speed;
                    break;
                case ConsoleKey.RightArrow:
                    XCursor += cursor_speed;
                    break;
                case ConsoleKey.LeftWindows:
                    Console.SetCursorPosition(15, 0);
                    Commands.Run(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.Delete:
                    Console.Write(" ");
                    Commands.Run(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.Backspace:
                    Console.Write(" ");
                    Commands.Run(Console.ReadLine());
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
