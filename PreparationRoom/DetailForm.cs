using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparationRoom
{
    public partial class DetailForm : Form
    {
        public DetailForm(Common.Order o)
        {
            Common.OrderItem[] items = o.order_items.order_items;
            ListViewItem current;
            InitializeComponent();
            for (int i = 0; i < items.Count(); ++i)
            {
                current = new ListViewItem(new string[] { items[i].item_name, items[i].item_ammount.ToString() });
                listView1.Items.Add(current);
            }
        }
    }
}
