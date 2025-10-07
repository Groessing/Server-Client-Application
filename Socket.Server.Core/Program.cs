using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Logging;
namespace Socket.Server.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ipAddress = "127.0.0.1";
            int port = 5000;


            DefaultLogWriter logWriter = new DefaultLogWriter();


            TCPServer server = new TCPServer(ipAddress, port, logWriter); //Server mit IP, Port und LogWriter initialisieren

            try
            {
                server.Start();
                Console.WriteLine("Press Enter to stop the server...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                logWriter.LogServerInfo($"Server error: {ex.Message}");
            }
            finally
            {
                server.Stop();
            }

        }
    }
}
