using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace ADOS
{
    public static class PowerControl
    {
        public static void Shutdown()
        {
            Sys.Power.Shutdown();
            Console.WriteLine("It's now save to turn off virtual machine");
        }

        public static void Reboot()
        {
            Sys.Power.Reboot();
            Console.WriteLine("It's now save to reboot virtual machine");
        }
    }
}
