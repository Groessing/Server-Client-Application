using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using Logging;
namespace Socket.Server.Core
{
    internal class ClientHandler
    {
        private System.Net.Sockets.Socket _serverSocket;
        private List<SessionHandler> _sessionHandlers;
        private Thread _clientHandlerThread;
        private Logging.DefaultLogWriter _logWriter;
        public ClientHandler(System.Net.Sockets.Socket serverSocket, DefaultLogWriter logWriter)
        {
            _serverSocket = serverSocket;
            _sessionHandlers = new List<SessionHandler>();
            _logWriter = logWriter;
        }


        public void AcceptClients()
        {
            while (true)
            {
                try
                {
                    var clientSocket = _serverSocket.Accept();
                    _logWriter.LogServerInfo("Client connected...");
                    var sessionHandler = new SessionHandler(clientSocket, new EchoRequestHandler(_logWriter)); 
                    _sessionHandlers.Add(sessionHandler); 
                    sessionHandler.Start(); 
                }
                catch (Exception ex)
                {
                    _logWriter.LogServerInfo($"Error accepting client: {ex.Message}");
                    break;
                }
            }
        }

        public void Close()
        {
            foreach(var session in _sessionHandlers)
            {
                session.Close();
            }
            _clientHandlerThread?.Abort();
        }
    }
}
