using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("TestClient.exe.config", false);
            Console.WriteLine("Press <Enter> to terminate.");

            Common.Order o = new Common.Order(null, null, 10);
            Common.OrderList list = new Common.OrderList();

            list.OnNew += list.HandleNew;

            list.AddOrder(o);

            

            Console.ReadLine();
        }

       



    }
}
