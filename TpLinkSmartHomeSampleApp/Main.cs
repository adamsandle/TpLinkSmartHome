using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TpLinkSmartHome;

namespace TpLinkSmartHomeSampleApp
{
    public static class Program
    {
        static void Main()
        {
            var plug = new Plug("192.168.1.5");
            plug.TogglePowerState();
        }
    }
}
