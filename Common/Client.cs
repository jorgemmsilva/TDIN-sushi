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
        public string name;
        public string address;
        public string cardno;

        public Client(string n, string a, string c)
        {
            name = n;
            address = a;
            cardno = c;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
