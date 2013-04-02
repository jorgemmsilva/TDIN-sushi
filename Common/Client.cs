using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Client
    {
        public string name { get; set; }
        public string address { get; set; }
        public string cardno { get; set; }

        public Client(string n, string a, string c)
        {
            name = n;
            address = a;
            cardno = c;
        }
    }
}
