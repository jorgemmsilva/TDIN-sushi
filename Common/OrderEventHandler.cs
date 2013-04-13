using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class OrderEventHandler : MarshalByRefObject
    {
        public BindingList<Order> relevant_orders;
        OrderList all_orders;

        public void HandleAddToOrders(int id)
        {
            lock (relevant_orders)
            {
                relevant_orders.Add(all_orders.GetOrder(id));
                Console.WriteLine(relevant_orders.Count);
            }
        }

        public void HandleRemoveFromOrders(int id)
        {
            Order target = relevant_orders.Where(o => o.id == id).FirstOrDefault();
            relevant_orders.Remove(target);
        }

        public OrderEventHandler(OrderList l, status wanted_status)
        {
            all_orders = l;
            relevant_orders = l.GetOrderWithStatus(wanted_status);
        }

    }
}
