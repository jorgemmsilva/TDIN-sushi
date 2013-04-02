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
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Server.exe.config", false);

            /*HandlerHolder h = new HandlerHolder();
            
            Common.OrderList db = new Common.OrderList();
            db.OnNew += h.handle;
            */
            Console.WriteLine("Press <Enter> to terminate.");
            Console.ReadLine();
        }
        /*
        public class HandlerHolder
        {
            public void handle(int id)
            {
                Console.WriteLine("id: " + id);
            }
        }
         * */
    }
}
