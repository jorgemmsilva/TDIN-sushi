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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.data.new_orders.relevant_orders;
            dataGridView2.DataSource = Program.data.preparing_orders.relevant_orders;
            PrepareButton.Click += PrepareListener;
            ReadyButton.Click += ReadyListener;
            DetailsButton.Click += DetailListener;

            CheckForIllegalCrossThreadCalls = false;
        }

        private void ReadyListener(object sender, EventArgs e)
        {
            OnReadyButton();
        }

        private void OnReadyButton()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(OnReadyButton));
            }
            else
            {
                DataGridViewSelectedRowCollection selected = dataGridView2.SelectedRows;
                Common.Order current_order;

                for (int i = 0; i < selected.Count; ++i)
                {

                    current_order = (Common.Order)selected[i].DataBoundItem;
                    Program.data.preparing_orders.HandleRemoveFromOrders(current_order.id);
                    Program.data.list.SetOrderReady(current_order.id);
                }
            }
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
                    Program.data.list.SetOrderPreparing(current_order.id);

                    Program.data.new_orders.HandleRemoveFromOrders(current_order.id);
                    Program.data.preparing_orders.HandleAddToOrders(current_order.id);
                }
            }
        }

        private void PrepareListener(object sender, EventArgs e)
        {
            OnPrepareButton();
        }

        private void DetailListener(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = dataGridView1.SelectedRows;
            Common.Order current_order;

            for (int i = 0; i < selected.Count; ++i)
            {

                current_order = (Common.Order)selected[i].DataBoundItem;
                DetailForm det = new DetailForm(current_order);
                det.Show();
            }
        }
    }
}
