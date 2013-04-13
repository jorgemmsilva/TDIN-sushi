using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class OrderItemArray
    {
        public OrderItem[] order_items { get; set; }

        public OrderItemArray(OrderItem[] items)
        {
            order_items = items;
        }

        public override string ToString()
        {
            String display = String.Empty;

            for (int i = 0; i < order_items.Length; ++i)
            {
                display += order_items[i].item_name + ' ' + order_items[i].item_ammount + '\n';
            }

            return display;
        }
    }

    [Serializable]
    public class OrderItem
    {
        public String item_name { get; set; }
        public int item_ammount { get; set; }

        public OrderItem(String n, int a)
        {
            item_name = n;
            item_ammount = a;
        }
    }
}
