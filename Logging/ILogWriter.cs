using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public interface ILogWriter
    {
        void LogServerInfo(string message);

        void LogRequestInfo(string message);
    }
}
