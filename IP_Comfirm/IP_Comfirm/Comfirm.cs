using System;
using System.Net;
using System.Net.Sockets;

namespace IP_Comfirm
{
    class Comfirm
    {
        static void Main(string[] args)
        {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            Console.WriteLine("IP Address = " + localIP);
            Console.ReadKey();
        }
    }
}
