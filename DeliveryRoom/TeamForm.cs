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
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
            SubmitButton.Click += SubmitListener;
        }

        private void SubmitListener(object sender, EventArgs e)
        {
            Program.UpdateId(textBox1.Text);
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartForm1));
            t.Start();
            this.Close();
        }

        private static void StartForm1()
        {
            Application.Run(new MainForm());
        }
    }
}
