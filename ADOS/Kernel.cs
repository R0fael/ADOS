using System;
using Sys = Cosmos.System;
using Asci = ADOS.Asci_Art;
using Console = System.Console;
using Cosmos.System.FileSystem;
using System.IO;
using System.Runtime.Versioning;
using FileSystem = ADOS.FileSystem;
using Power = ADOS.PowerControl;
using ConsoleX = ADOS.ConsoleUtilits;
using Cosmos.System;
using Web = ADOS.Web;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.Config;
using CLI = ADOS.CLI;
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
        private async void Run_console()
        {
            CLI.Update();
        }
    }
}
