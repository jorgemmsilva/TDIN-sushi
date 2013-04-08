using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryRoom
{
    class ProgramData
    {
        public Common.OrderList list;
        public Common.OrderEventHandler awaiting_delivery;
        public Common.OrderEventHandler my_deliveries;

        public void Initialize()
        {
            list = new Common.OrderList();
            awaiting_delivery = new Common.OrderEventHandler(list);
            my_deliveries = new Common.OrderEventHandler(list);

            list.OnReady += awaiting_delivery.HandleAddToOrders;
            list.OnDelivering += awaiting_delivery.HandleRemoveFromOrders;

            list.OnFinished += my_deliveries.HandleRemoveFromOrders;
        }

        public ProgramData()
        {
            Initialize();
        }
    }
    static class Program
    {
        static string deliver_id;
        static ProgramData data;
        static void Initialize()
        {
            //TODO: carregar a deliver_id a partir de um ficheiro
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
