using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Show();
        }

        private void ButtonStatus_Click(object sender, EventArgs e)
        {
            OrderStatus form = new OrderStatus();
            form.Show();
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            Stock form = new Stock();
            form.Show();
        }

        private void ShipmentsButton_Click(object sender, EventArgs e)
        {
            Shipments form = new Shipments();
            form.Show();

        }
    }
}
