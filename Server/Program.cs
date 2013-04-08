using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static Common.OrderList orders;

        public static void LoadOrdersFromFile(string filename)
        {
        }

        public static void SaveOrdersInFile(string filename)
        {
        }
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Server.exe.config", false);

            Console.WriteLine("Press <Enter> to terminate.");
            Console.ReadLine();
        }

    }
}
