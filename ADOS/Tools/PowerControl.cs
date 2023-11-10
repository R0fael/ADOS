using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using ConsoleX = ADOS.Tools.ConsoleX;

namespace ADOS.Tools
{
    public static class PowerControl
    {
        public static void Shutdown()
        {
            Sys.Power.Shutdown();
            ConsoleX.Print("It's now save to turn off virtual machine");
        }

        public static void Reboot()
        {
            Sys.Power.Reboot();
            ConsoleX.Print("It's now save to reboot virtual machine");
        }
    }
}
