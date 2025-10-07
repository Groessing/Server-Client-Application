using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Socket.Server.Core
{
    public class TCPServer
    {


        private System.Net.Sockets.Socket _serverSocket;
        private IPEndPoint _ipEndpoint;
        private ClientHandler _clientHandler;
        private Thread _listenerThread;
        private Logging.DefaultLogWriter _logWriter;
        public TCPServer(string ipAddress, int port, DefaultLogWriter logWriter)
        {
            _ipEndpoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            _logWriter = logWriter;
        }

        public TCPServer(IPEndPoint ipEndpoint, DefaultLogWriter logWriter)
        {
            _ipEndpoint = ipEndpoint;
            _logWriter = logWriter;
        }

        public void Start()
        {
            Bind();
            Listen();
            _logWriter.LogServerInfo("Server started...");
            _clientHandler = new ClientHandler(_serverSocket, _logWriter);
            _listenerThread = new Thread(_clientHandler.AcceptClients);
            _listenerThread.Start();


        }

        public void Stop()
        {
            _clientHandler.Close();
            _serverSocket.Close();
            _logWriter.LogServerInfo("Server stopped...");
        }

        private void Bind()
        {
            _serverSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(_ipEndpoint);
            _logWriter.LogServerInfo("Server bound");
        }

        private void Listen()
        {
            _serverSocket.Listen(10);
            _logWriter.LogServerInfo("Listening for connections...");
        }




       
    }
}
