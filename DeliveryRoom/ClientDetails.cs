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
    public partial class ClientDetails : Form
    {
        public ClientDetails(Common.Client c)
        {
            InitializeComponent();
            label2.Text = c.name;
            label4.Text = c.address;
        }
    }
}
