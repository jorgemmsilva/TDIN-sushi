﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    

    
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
                return new Dictionary<int, Common.Order>();
            }
        }

        public void SaveOrdersInFile(string filename)
        {
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

        public BindingList<Order> GetOrderWithStatus(status s)
        {
            BindingList<Order> l = new BindingList<Order>();
            foreach (Order o in orders.Values)
            {
                if(o.order_status == s)
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

        public void FireNew(int id)
        {
            this.OnNew(id);
        }

        public void FirePreparing(int id)
        {
            this.OnPreparing(id);
        }

        public void FireReady(int id)
        {
            this.OnReady(id);
        }

        public void FireDelivering(int id)
        {
            this.OnDelivering(id);
        }

        public void FireFinished(int id)
        {
            this.OnFinished(id);
        }

        public void SetOrderPreparing(int id)
        {
            GetOrder(id).order_status = status.preparacao;
            SetPaymentTimestamp(id);
            //FirePreparing(id);
        }

        public void SetOrderReady(int id)
        {
            GetOrder(id).order_status = status.pronta;
            FireReady(id);
        }

        public void SetOrderDelivering(int id, string team)
        {
            Order o = GetOrder(id);
            o.order_status = status.entrega;
            o.delivery_team = team;
            FireDelivering(id);
        }

        public void SetOrderFinished(int id)
        {
            GetOrder(id).order_status = status.concluida;
            FireFinished(id);
        }

        public void SetPaymentTimestamp(int id)
        {
            Order o = GetOrder(id);
            o.payment_time = DateTime.Now;
        }

        public BindingList<Order> GetTeamDeliveries(string team_id)
        {
            BindingList<Order> l = new BindingList<Order>();
            foreach (Order o in orders.Values)
            {
                if (o.order_status == status.entrega && o.delivery_team != null && o.delivery_team.Equals(team_id))
                    l.Add(o);
            }
            return l;
        }
    }
}
