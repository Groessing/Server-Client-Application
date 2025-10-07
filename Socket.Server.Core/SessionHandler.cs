using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using Logging;
using System.Runtime.Remoting.Messaging;
namespace Socket.Server.Core
{
    internal class SessionHandler
    {

        private System.Net.Sockets.Socket _sessionSocket;
        private Socket.Communication.SocketReader _socketReader;
        private Socket.Communication.SocketWriter _socketWriter;
        private IRequestHandler _echoRequestHandler;
        private Thread _sessionThread;
        private CharacterCountRequestHandler charHandler;

        public SessionHandler(System.Net.Sockets.Socket socket, IRequestHandler requestHandler)
        {
            _sessionSocket = socket;
            _socketReader = new Socket.Communication.SocketReader();
            _socketWriter = new Socket.Communication.SocketWriter();
            _echoRequestHandler = requestHandler;
            charHandler = new CharacterCountRequestHandler();
        }
        public void Start()
        {
            _sessionThread = new Thread(HandleSession);
            _sessionThread.Start();
        }

        public void Close()
        {
            _sessionSocket.Close();
            _sessionThread?.Abort();
        }

        public void HandleSession()
        {
            try
            {
                while (true)
                {
                    string request = _socketReader.Read(_sessionSocket); 
                    if (string.IsNullOrWhiteSpace(request)) break;

                    _echoRequestHandler.HandleRequest(request);

                    //string[] parts = request.Split(':');
                    //if (parts.Length != 2 || !int.TryParse(parts[1], out int count)) continue;
                    //string message = parts[0];
                    //string response = string.Join(" ", Enumerable.Repeat(message, count));


                    //string response = Convert.ToString(charHandler.CountChars(request));
                    //_socketWriter.Write(_sessionSocket, response);

                    string filtered = request.Replace("ä", "");
                    filtered = request.Replace("ü", "");
                    filtered = request.Replace("ö", "");
                    string response = filtered + ";" + Convert.ToString(charHandler.CountChars(request));
                    _socketWriter.Write(_sessionSocket, response);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Session error: {ex.Message}");
            }
            finally
            {
                Close();
            }
        }
    }
}
