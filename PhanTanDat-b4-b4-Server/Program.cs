using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PhanTanDat_b4_b4_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];

            TcpListener server = new TcpListener(12345);
            server.Start();

            Console.WriteLine("Waiting for a client...");
            TcpClient client = server.AcceptTcpClient();
            NetworkStream ns = client.GetStream();

            Console.Write("Chon lenh: ");
            string cmd = Console.ReadLine();
            data = Encoding.ASCII.GetBytes(cmd);
            ns.Write(data, 0, data.Length);
        }
    }
}
