using System;
using Sys = Cosmos.System;
using Asci = ADOS.Tools.Asci_Art;
using Console = System.Console;
using Cosmos.System.FileSystem;
using System.IO;
using System.Runtime.Versioning;
using FileSystem = ADOS.FileSystem;
using Power = ADOS.Tools.PowerControl;
using ConsoleX = ADOS.Tools.ConsoleX;
using Cosmos.System;
using Web = ADOS.Tools.Web;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.Config;
using CLI = ADOS.Things.CLI;
using Getos = ADOS.GetOSes;
using System.Threading;
using System.Threading.Tasks;

namespace ADOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Web.DinamicIP(new Sys.Network.IPv4.UDP.DHCP.DHCPClient());
            FileSystem.fs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(FileSystem.fs);
            ConsoleX.Start();
            Console.Clear();
            Console.CursorVisible = false;
        }

        protected override void Run()
        {
            try
            {
                Run_console();
            }
            catch (Exception e) { ConsoleX.CriticalError(e.ToString()); }
        }
        private void Run_console()
        {
            CLI.Update();
        }
    }
}
