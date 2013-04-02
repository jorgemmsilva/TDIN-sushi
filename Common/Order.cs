using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum status
    {
        encomendada, preparacao, pronta, entrega, concluida 
    }

    public class Order
    {
        public static int current_id = 1;

        public sealed int id {get;}
        public sealed Client client { get; }
        public sealed OrderItem[] order_items { get; }
        public status order_status { get; set; }
        public sealed float total_price { get; }

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
