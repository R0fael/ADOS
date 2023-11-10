using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConsoleX = ADOS.Tools.ConsoleX;

namespace ADOS.Things
{
    public class Engine2D
    {
        public static void DrawSquare(Vector2 pos1, Vector2 pos2, char symbol)
        {
            Console.SetCursorPosition((int)pos1.X, (int)pos1.Y);
            for (int i = (int)pos1.Y; i < (int)pos2.Y; i++)
            {
                for (int j = (int)pos1.X; j < (int)pos2.X; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static void DrawLine(Vector2 pos1, Vector2 pos2, char symbol)
        {
            int x = (int)pos1.X;
            int y = (int)pos1.Y;
            int x2 = (int)pos2.X;
            int y2 = (int)pos2.Y;
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                if (x! < 0 && x! > 88 && y! < 0 && y! > 59)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(symbol);
                }
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }

        public static void DrawPolygon(Vector2[] points, char symbol)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (i != points.Length - 1)
                {
                    DrawLine(points[i], points[i + 1], symbol);
                }
                else
                {
                    DrawLine(points[i], points[0], symbol);
                }
            }
        }
    }
}
