using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace Socket.Communication
{
    public class SocketWriter
    {
        public SocketWriter()
        {

        }

        public void Write(System.Net.Sockets.Socket socket, string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            socket.Send(data);
        }

        public void Write(System.Net.Sockets.Socket socket, byte[] buffer)
        {
            socket.Send(buffer);
        }
    }


}
