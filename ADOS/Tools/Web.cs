using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.TCP;
using Cosmos.System.Network.IPv4.UDP;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4.UDP.DNS;

namespace ADOS.Tools
{
    public class Web
    {
        public static void StaticIP(string device_name = "eth0")
        {
            try
            {
                NetworkDevice nic = NetworkDevice.GetDeviceByName(device_name);
                IPConfig.Enable(nic, new Address(192, 168, 1, 69), new Address(255, 255, 255, 0), new Address(192, 168, 1, 254));
            }
            catch
            {
                Console.WriteLine("Error with the Internet Connection");
                Console.WriteLine("Today no internet :(");
            }
        }
        public static void DinamicIP(DHCPClient xClient)
        {
            try
            {
                xClient.SendDiscoverPacket();
                Console.WriteLine("Connected To internet sucesfully");
            }
            catch
            {
                Console.WriteLine("Retrying...");
                StaticIP();
            }
        }

        public static void TCP_Server(TcpListener xServer, string s)
        {
            xServer.Start();
            var client = xServer.AcceptTcpClient();
            xServer.Stop();
            client.Send(Encoding.ASCII.GetBytes(s));
        }

        public static string[] TCP_Client(TcpClient xClient, Address adreess, int port, string s)
        {
            xClient.Connect(adreess, port);

            xClient.Send(Encoding.ASCII.GetBytes(s));

            var endpoint = new Cosmos.System.Network.IPv4.EndPoint(Address.Zero, 0);
            var data = xClient.Receive(ref endpoint);
            var data2 = xClient.NonBlockingReceive(ref endpoint);

            string a = "";
            string b = "";

            foreach (var packet in data)
            {
                a += packet;
            }
            foreach (var packet in data2)
            {
                b += packet;
            }
            string[] res = { a, b };
            return res;

        }
        public static byte[] UDP_Client(UdpClient xClient, Address adreess, int port, string s)
        {
            xClient.Connect(adreess, port);

            xClient.Send(Encoding.ASCII.GetBytes(s));

            var endpoint = new Cosmos.System.Network.IPv4.EndPoint(Address.Zero, 0);
            return xClient.Receive(ref endpoint);
        }
        public static int TCMP_Client(ICMPClient xClient, Address address)
        {
            xClient.Connect(address);

            xClient.SendEcho();

            var endpoint = new Cosmos.System.Network.IPv4.EndPoint(Address.Zero, 0);
            return xClient.Receive(ref endpoint);
        }
        public static Address DNS_Client(DnsClient xClient, Address address, string url)
        {
            xClient.Connect(address);

            xClient.SendAsk(url);

            return xClient.Receive();
        }
    }
}