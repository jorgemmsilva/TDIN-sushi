using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Server.exe.config", false);

            Console.WriteLine("Press <Enter> to terminate.");
            Console.ReadLine();
        }

    }
}
