using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekPoşeti
{
    partial class ucRMOrders : UserControl
    {
        private Restaurant ownedRestaurant;
        public int orderID {get;set;}
        public ucRMOrders(Restaurant rest)
        {
            InitializeComponent();
            this.ownedRestaurant = rest;
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            ownedRestaurant.SetOrderState(orderID,2);
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            ownedRestaurant.SetOrderState(orderID, 3);
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ownedRestaurant.SetOrderState(orderID, 4);
        }
    }
}
