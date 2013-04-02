using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    interface OrderList
    {
        public delegate int StatusChange();

        public event StatusChange OnNew;
        public event StatusChange OnPreparing;
        public event StatusChange OnReady;
        public event StatusChange OnDelivering;
        public event StatusChange OnFinished;

        public void AddOrder(Order o);
        public Order GetOrder(int id);
        public void SetOrderPreparing(int id);
        public void SetOrderReady(int id);
        public void SetOrderDelivering(int id);
        public void SetOrderFinished(int id);
    }
}
