using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket.Communication
{
    public class SocketReader
    {

        public SocketReader()
        {

        }

        public string Read(System.Net.Sockets.Socket socket)
        {
            byte[] buffer = new byte[1024];
            int received = socket.Receive(buffer);
            return Encoding.UTF8.GetString(buffer, 0, received);
        }

        public void Read(System.Net.Sockets.Socket socket, byte[] buffer)
        {
            socket.Receive(buffer);
        }
    }
}
