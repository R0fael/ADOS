using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleX = ADOS.Tools.ConsoleX;
using FileSystem = ADOS.FileSystem;

namespace ADOS
{
    public class GetOSes
    {
        public static void GetList()
        {
            ConsoleX.Print("Finding Operating Systems...");
            if (FileSystem.DoesExist(@"0:\NclearOS"))
            {
                ConsoleX.Print(@"found NclearOS or NclearOS2 at 0:\NclearOS");
            }
            if (FileSystem.DoesExist(@"0:\ADOS"))
            {
                ConsoleX.Print(@"found ADOS at 0:\ADOS");
            }
            if (FileSystem.DoesExist(@"0:\TEST"))
            {
                ConsoleX.Print(@"found Cosmos at 0:\");
            }
            ConsoleX.Print("All known OSes scanned");
        }
    }
}
