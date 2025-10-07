using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;
using Socket.Communication;
using UI;
namespace Socket.Client
{
    public class ClientClass
    {
        ISetData datahandler = new ClientDataHandler();
        private System.Net.Sockets.Socket _clientSocket;
        ILogWriter _logWriter;
        public ClientClass(string serverIP, int serverPort, ILogWriter logwriter = null)
        {
            _logWriter = logwriter ?? new DefaultLogWriter();
            _clientSocket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
            _clientSocket.Connect(serverIP, serverPort);
            _logWriter.LogServerInfo("Client connected to server...");
           
        }
        //public void SendMessage(string message, int count)
        //{
        //    try
        //    {
        //        // string request = $"{message}:{count}";
        //        byte[] requestbytes = Encoding.UTF8.GetBytes(message);
        //        _clientSocket.Send(requestbytes);
             
        //    }
           

        //    catch (Exception ex)
        //    {
        //       _logWriter.LogServerInfo($"Error sending message: {ex.Message}");
        //    }

        //}

        //public void ReceiveMessage()
        //{
        //    byte[] buffer = new byte[1024];
        //    int received = _clientSocket.Receive(buffer);
        //    string response = Encoding.UTF8.GetString(buffer, 0, received);
        //    Console.WriteLine($"Response from server: {response}");
        //    _logWriter.LogRequestInfo($"Received response: {response}");
           
        //}

        public string RequestResponse(string req)
        {
            try
            {
                // string request = $"{message}:{count}";
                byte[] requestbytes = Encoding.UTF8.GetBytes(req);
                _clientSocket.Send(requestbytes);

                byte[] buffer = new byte[1024];
                int received = _clientSocket.Receive(buffer);
                string response = Encoding.UTF8.GetString(buffer, 0, received);
                Console.WriteLine($"Response from server: {response}");
                _logWriter.LogRequestInfo($"Received response: {response}");
                return response;
            }


            catch (Exception ex)
            {
                _logWriter.LogServerInfo($"Error sending message: {ex.Message}");
                return null;
            }
            
        }

        public void Close()
        {
            _clientSocket.Close();
            _logWriter.LogServerInfo("Client socket closed.");
        }
    }
}
