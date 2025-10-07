using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket.Server.Core
{
    public interface IRequestHandler
    {

        void HandleRequest(string echo, int count);
        void HandleRequest(string request);
    }
}
