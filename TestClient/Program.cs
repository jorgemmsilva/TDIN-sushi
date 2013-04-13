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

            Common.OrderList list = new Common.OrderList();
            Common.OrderItem[] cenas = new Common.OrderItem[1];
            cenas[0] = new Common.OrderItem("sushi", 1);
            Common.Order o = new Common.Order(list.GetCurrentId(), new Common.Client("hudur", "morada", "c"), cenas, 10);
            
            //list.OnNew += list.HandleOnNew;
            Common.OrderEventHandler hand = new Common.OrderEventHandler(list);
            list.OnNew += hand.HandleAddToOrders;

            //list.OnPreparing += new Common.OrderEventHandler().HandleOnPreparing;

            list.AddOrder(o);

            Console.Write(hand.relevant_orders.Count);
            Console.ReadLine();
            list.OnNew -= hand.HandleAddToOrders;
        }

    }
}
