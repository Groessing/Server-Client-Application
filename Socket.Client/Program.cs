using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace Socket.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            //string serverIP = "127.0.0.1"; 
            //int serverPort = 5000;         
            
            DefaultLogWriter logWriter = new DefaultLogWriter();
            try
            {
                Console.Write("IP Address: ");
                string serverIP = Console.ReadLine();
                Console.Write("Port: ");
                int serverPort = Convert.ToInt32(Console.ReadLine());
                ClientClass client = new ClientClass(serverIP, serverPort);
                logWriter.LogServerInfo("Connected to the server...");

                while (true)
                {
                    Console.Write("Enter your message (or '#exit#' to quit): ");
                    string message = Console.ReadLine();

                    if (message?.ToLower() == "#exit#")
                    {
                        break;
                    }

                    //Console.Write("Enter the count: ");
                    //if (!int.TryParse(Console.ReadLine(), out int count))
                    //{
                    //    logWriter.LogRequestInfo("Invalid count entered.");
                    //    Console.WriteLine("Invalid count. Please enter a number.");
                    //    continue;
                    //}

                   
                    client.RequestResponse(message);
                }

                client.Close();
                logWriter.LogServerInfo("Disconnected from the server.");
            }
            catch (Exception ex)
            {
                logWriter.LogServerInfo($"Error: {ex.Message}");
            }
        }
          


        
    }
}
