using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        public List<Order> relevant_orders = new List<Order>();
        OrderList all_orders;
        public void HandleAddToOrders(int id)
        {
            relevant_orders.Add(all_orders.GetOrder(id));
        }

        public void HandleRemoveFromOrders(int id)
        {
            relevant_orders.RemoveAll(ord => ord.id == id);
        }

        public OrderEventHandler(OrderList l)
        {
            all_orders = l;
        }
        
    }
    
    public delegate void StatusChange(int id);

    public class OrderList : MarshalByRefObject
    {

        public void writeToConsole(string s)
        {
            Console.WriteLine(s);
        }

        static string default_orders_file = "orders.bin";

        public Dictionary<int, Order> orders;

        public Dictionary<int, Common.Order> LoadOrdersFromFile(string filename)
        {
            try
            {
                Dictionary<int, Common.Order> loaded_orders;
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                loaded_orders = (Dictionary<int, Common.Order>)formatter.Deserialize(stream);
                stream.Close();

                return loaded_orders;
            }
            catch (Exception e)
            {
                Console.WriteLine("poop");
                return new Dictionary<int, Common.Order>();
            }
        }

        public void SaveOrdersInFile(string filename)
        {
            //Console.WriteLine(orders.Count);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, orders);
            stream.Close();
        }

        int current_id;

        public event StatusChange OnNew;
        public event StatusChange OnPreparing;
        public event StatusChange OnReady;
        public event StatusChange OnDelivering;
        public event StatusChange OnFinished;


        public OrderList()
        {
            orders = LoadOrdersFromFile(default_orders_file);
            Console.WriteLine(orders.Count);
            current_id = orders.Count;
        }

        ~OrderList()
        {
            SaveOrdersInFile(default_orders_file);
        }

        public int GetCurrentId()
        {
            ++current_id;
            return current_id;
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
        public void SetOrderPreparing(int id)
        {
            GetOrder(id).order_status = status.preparacao;
            FirePreparing(id);
        }

        public void SetOrderReady(int id)
        {
            GetOrder(id).order_status = status.pronta;
            FireReady(id);
        }

        public void SetOrderDelivering(int id)
        {
            GetOrder(id).order_status = status.entrega;
            FireDelivering(id);
        }

        public void SetOrderFinished(int id)
        {
            GetOrder(id).order_status = status.concluida;
            FireFinished(id);
        }*/
    }
}
