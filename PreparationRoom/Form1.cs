using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparationRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.data.new_orders.relevant_orders;
            dataGridView2.DataSource = Program.data.preparing_orders.relevant_orders;
            PrepareButton.Click += PrepareListener;

            CheckForIllegalCrossThreadCalls = false;
        }

        private void OnPrepareButton()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(OnPrepareButton));
            }
            else
            {
                DataGridViewSelectedRowCollection selected = dataGridView1.SelectedRows;
                Common.Order current_order;

                for (int i = 0; i < selected.Count; ++i)
                {
                    
                    current_order = (Common.Order)selected[i].DataBoundItem;
                    current_order = Program.data.list.GetOrder(current_order.id);
                    current_order.order_status = Common.status.preparacao;
                    Program.data.list.FirePreparing(current_order.id);
                }
            }
        }

        private void PrepareListener(object sender, EventArgs e)
        {
            OnPrepareButton();
        }
    }
}
