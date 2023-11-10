using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleX = ADOS.Tools.ConsoleX;

namespace ADOS.Tools
{
    //This is for making own app for ADOS and for AOS
    public abstract class App
    {
        public bool is_console_app = true;

        public readonly string name = "Test name";
        public readonly string licence = "Put the licence here and in info that will show";
        public readonly string privacy_policy = "Put the privacy policy here and in info that will show";
        public static void Startup()
        {
            // Do not change this code
            try
            {
                Run();
            }
            catch (Exception e) { ConsoleX.Cerror(e.ToString()); }
        }
        public static void Run()
        {
            // Use this as run code for app

        }
    }
}
