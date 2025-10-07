using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class DefaultLogWriter : ILogWriter
    {
        public void LogServerInfo(string message)
        {
            Console.WriteLine(message);
        }

        public void LogRequestInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
