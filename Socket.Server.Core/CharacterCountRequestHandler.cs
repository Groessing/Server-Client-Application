using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Socket.Server.Core
{
    public class CharacterCountRequestHandler
    {
        public CharacterCountRequestHandler()
        {

        }

        public int CountChars(string request)
        {
            int i = 0;
            int length = request.Length;
            while (i < length)
            {

                if (request[i] == 'ö' || request[i] == 'ä' && request[i] == 'ü')
                {
                    length--;
                }
                i++;

            }
            return i;
        }
    }
}
