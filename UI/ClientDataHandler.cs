using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ClientDataHandler : ISetData
    {
        public void SetReceivedDataGUI(string information)
        {
            Console.WriteLine($"[GUI Update]: {information}");
        }

        public void SetReceivedDataCUI(string information)
        {
            Console.WriteLine($"[CUI Update]: {information}");
        }
    }
}
