using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public delegate void StatusChange(int id);

    public class OrderList : MarshalByRefObject
    {
        Dictionary<int, Common.Order> orders;

        public event StatusChange OnNew;
        public event StatusChange OnPreparing;
        public event StatusChange OnReady;
        public event StatusChange OnDelivering;
        public event StatusChange OnFinished;

        public OrderList()
        {
            orders = new Dictionary<int, Common.Order>();
            Console.Write("cenas");
        }

        public virtual void AddOrder(Order o)
        {
            orders.Add(o.id, o);
            FireNew(o.id);
        }

        public virtual Order GetOrder(int id)
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
            OnPreparing(id);
        }

        protected void FireReady(int id)
        {
            OnReady(id);
        }

        protected void FireDelivering(int id)
        {
            OnDelivering(id);
        }

        protected void FireFinished(int id)
        {
            OnFinished(id);
        }
        /*
        public void SetOrderPreparing(int id);
        public void SetOrderReady(int id);
        public void SetOrderDelivering(int id);
        public void SetOrderFinished(int id);*/
    }
}
