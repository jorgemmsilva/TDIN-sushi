using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparationRoom
{

    class ProgramData
    {
        public Common.OrderList list;
        public Common.OrderEventHandler new_orders;
        public Common.OrderEventHandler preparing_orders;

        public void Initialize()
        {
            list = new Common.OrderList();
            new_orders = new Common.OrderEventHandler(list);
            preparing_orders = new Common.OrderEventHandler(list);

            list.OnNew += new_orders.HandleAddToOrders;
            list.OnPreparing += new_orders.HandleRemoveFromOrders;

            list.OnPreparing += preparing_orders.HandleAddToOrders;
            list.OnReady += preparing_orders.HandleRemoveFromOrders;
        }

        public ProgramData()
        {
            Initialize();
        }
    }

    static class Program
    {
        static ProgramData data;

        static void Initialize()
        {
            RemotingConfiguration.Configure("PreparationRoom.exe.config", false);
            data = new ProgramData();
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
