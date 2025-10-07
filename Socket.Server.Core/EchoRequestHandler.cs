using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket.Server.Core
{
    public class EchoRequestHandler : IRequestHandler
    {
        private readonly ILogWriter _logWriter;
        public EchoRequestHandler(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }
        public void HandleRequest(string echo, int count)
        {
            _logWriter.LogRequestInfo($"Received request: {echo} at " + DateTime.Now.ToString("hh:mm:ss tt"));
        }

        public void HandleRequest(string request)
        {
            _logWriter.LogRequestInfo($"Received request: {request} at " + DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
