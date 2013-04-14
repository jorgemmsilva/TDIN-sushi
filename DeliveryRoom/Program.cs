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

        public void Initialize(Common.OrderList l)
        {
            list = l;
            awaiting_delivery = new Common.OrderEventHandler(list, Common.status.pronta);
            my_deliveries = new Common.OrderEventHandler(list, Common.status.entrega);

            list.OnReady += awaiting_delivery.HandleAddToOrders;
            list.OnDelivering += awaiting_delivery.HandleRemoveFromOrders;

            list.OnFinished += my_deliveries.HandleRemoveFromOrders;
        }

        public ProgramData(Common.OrderList l)
        {
            Initialize(l);
        }
    }
    static class Program
    {
        public static string deliver_id;
        public static ProgramData data;
        static void Initialize()
        {
            //TODO: carregar a deliver_id a partir de um ficheiro
            RemotingConfiguration.Configure("DeliveryRoom.exe.config", false);
            Common.OrderList list = new Common.OrderList();
            data = new ProgramData(list);
        }

        public static void UpdateId(string id)
        {
            deliver_id = id;
            data.my_deliveries.GetAllTeamOrders(id);
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
            Application.Run(new TeamForm());
        }
    }
}
