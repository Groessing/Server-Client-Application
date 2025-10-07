using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class ServerDataHandler
    {
        public void SetReceivedDataGUI(string information)
        {
            Console.WriteLine($"[Server GUI]: {information}");
        }

        public void SetReceivedDataCUI(string information)
        {
            Console.WriteLine($"[Server CUI]: {information}");
        }
    }
}
