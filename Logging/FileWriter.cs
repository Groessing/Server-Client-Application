using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Logging
{
    public class FileWriter : ILogWriter
    {
        public void LogServerInfo(string message)
        {
            File.AppendAllText("serverinfo", message);
        }

        public void LogRequestInfo(string message)
        {
            Console.WriteLine("requestinfo", message);
        }
    }
}
