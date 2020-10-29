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
	partial class ucBasketItem : UserControl
	{
		public int FoodID { get; set; }
		public int QTY = 1;
		public float Price { get; set; }
		public string FoodName { get; set; }
		public string FoodDesc { get; set; }
		public float SumPrice { get; set; }

		public MainScreen ms;

		public ucBasketItem()
		{
			InitializeComponent();
		}

		private void lblDeleteFood_Click(object sender, EventArgs e)
		{
            ms.LoggedUser.CurrentOrder.Basket.RemoveFood(this);
		}

        private void lblFoodDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
