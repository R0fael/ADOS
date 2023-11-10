using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConsoleX = ADOS.Tools.ConsoleX;
using E2D = ADOS.Things.Engine2D;

namespace ADOS.Things
{
    public class Engine3D
    {
        public string map = "#########.......#...............#.......#########..............##......##......##......##......##..............####............###.............##......####..####......#.......##......#.......##..............##......##########..............#################";
        private static Vector3 camera_pos = Vector3.Zero;


        public static void Draw3dTriangele(Vector3 pos1, Vector3 pos2, Vector3 pos3, char symbol = '@')
        {
            Vector2[] points2d = { new Vector2(pos1.X, pos1.Y) - new Vector2(camera_pos.X, camera_pos.Y), new Vector2(pos2.X, pos2.Y) - new Vector2(camera_pos.X, camera_pos.Y), new Vector2(pos3.X, pos3.Y) - new Vector2(camera_pos.X, camera_pos.Y) };
            E2D.DrawPolygon(points2d, symbol);
        }
    }
}
