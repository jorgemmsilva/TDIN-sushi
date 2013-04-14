using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum status
    {
        encomendada, preparacao, pronta, entrega, concluida 
    }

    [Serializable]
    public class Order
    {

        public int id { get; set; }
        public Client client { get; set; }
        public OrderItemArray order_items { get; set; }
        public status order_status { get; set; }
        public float total_price { get; set; }
        public DateTime payment_time { get; set; }
        public string delivery_team { get; set; }

        public Order(int i, Client c, OrderItem[] items, float price)
        {
            client = c;
            order_items = new OrderItemArray(items);
            total_price = price;

            id = i;

            order_status = status.encomendada;
            delivery_team = "";
        }

        public Order()
        {
            order_status = status.encomendada;
            delivery_team = "";
        }

        public static String getStatusString(status s)
        {
            if (s == status.encomendada)
                return "encomendada";
            else if (s == status.preparacao)
                return "em preparação";
            else if (s == status.pronta)
                return "pronta para entrega";
            else if (s == status.entrega)
                return "em entrega";
            else if (s == status.concluida)
                return "concluída";
            return null;
        }
    }
}
