using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryRoom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TeamIDLabel.Text = Program.deliver_id;
            dataGridView1.DataSource = Program.data.awaiting_delivery.relevant_orders;
            dataGridView2.DataSource = Program.data.my_deliveries.relevant_orders;

            DeliveringButton.Click += DeliveryListener;
            FinishButton.Click += FinishListener;
            DetailsButton.Click += DetailListener;

            CheckForIllegalCrossThreadCalls = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeliveryListener(object sender, EventArgs e)
        {
            OnDeliveryButton();
        }

        private void OnDeliveryButton()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(OnDeliveryButton));
            }
            else
            {
                DataGridViewSelectedRowCollection selected = dataGridView1.SelectedRows;
                Common.Order current_order;

                for (int i = 0; i < selected.Count; ++i)
                {

                    current_order = (Common.Order)selected[i].DataBoundItem;
                    Program.data.awaiting_delivery.HandleRemoveFromOrders(current_order.id);
                    Program.data.list.SetOrderDelivering(current_order.id, Program.deliver_id);
                    Program.data.my_deliveries.HandleAddToOrders(current_order.id);
                }
            }
        }

        private void FinishListener(object sender, EventArgs e)
        {
            OnFinishButton();
        }

        private void OnFinishButton()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(OnFinishButton));
            }
            else
            {
                DataGridViewSelectedRowCollection selected = dataGridView2.SelectedRows;
                Common.Order current_order;

                for (int i = 0; i < selected.Count; ++i)
                {

                    current_order = (Common.Order)selected[i].DataBoundItem;
                    Program.data.my_deliveries.HandleRemoveFromOrders(current_order.id);
                    Program.data.list.SetOrderFinished(current_order.id);
                }
            }
        }

        private void DetailListener(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = dataGridView1.SelectedRows;
            Common.Order current_order;

            for (int i = 0; i < selected.Count; ++i)
            {

                current_order = (Common.Order)selected[i].DataBoundItem;
                ClientDetails det = new ClientDetails(current_order.client);
                det.Show();
            }
        }
    }
}
