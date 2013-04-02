using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /*
    public interface IOrders
    {
        void AddOrder(Order o);
        Order GetOrder(int id);
    }
      */
    
    public class OrderEventHandler : MarshalByRefObject
    {
        public void HandleOnPreparing(int id)
        {
            Console.WriteLine("preparing order: " + id);
        }
        
    }
    
    public delegate void StatusChange(int id);

    public class OrderList : MarshalByRefObject
    {
        Dictionary<int, Common.Order> orders;

        public event StatusChange OnNew;
        public event StatusChange OnPreparing;
        public event StatusChange OnReady;
        public event StatusChange OnDelivering;
        public event StatusChange OnFinished;

        public void HandleOnNew(int id)
        {
            Console.WriteLine("created new order id: " + id);
            FirePreparing(id);
        }


        public OrderList()
        {
            orders = new Dictionary<int, Common.Order>();

        }

        public List<Order> GetAllOrders()
        {
            List<Order> l = new List<Order>();
            foreach (Order o in orders.Values){
                l.Add(o);
            }
            return l;
        }

        public void AddOrder(Order o)
        {
            orders.Add(o.id, o);
            FireNew(o.id);
        }

        public Order GetOrder(int id)
        {
            Common.Order o;

            if (orders.TryGetValue(id, out o))
                return o;
            else
                return null;
        }

        protected void FireNew(int id)
        {
            this.OnNew(id);
        }

        protected void FirePreparing(int id)
        {
            this.OnPreparing(id);
        }

        protected void FireReady(int id)
        {
            this.OnReady(id);
        }

        protected void FireDelivering(int id)
        {
            this.OnDelivering(id);
        }

        protected void FireFinished(int id)
        {
            this.OnFinished(id);
        }
        /*
        public void SetOrderPreparing(int id);
        public void SetOrderReady(int id);
        public void SetOrderDelivering(int id);
        public void SetOrderFinished(int id);*/
    }
}
