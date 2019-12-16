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
    public partial class ucFoodList : UserControl
	{
		public int FoodID { get; set; }
		public float Price { get; set; }
		private MainScreen MS;
		
        public ucFoodList()
        {
            InitializeComponent();
        }

		private void ucFoodList_Load(object sender, EventArgs e)
		{
			
		}

		public ucBasket AddFoodToBasket(MainScreen ms)
		{
			MS = ms;
			int id = CheckID(FoodID);
			if (id == -1)
			{
				ucBasket ucBasket = new ucBasket();
				MS.foodIDList.Add(this.FoodID);
				ucBasket.Dock = DockStyle.Top;
				ucBasket.FoodID = this.FoodID;
				ucBasket.Price = this.Price;
				ucBasket.FoodName = this.lblFoodName.Text;
				ucBasket.FoodDesc = this.lblFoodDesc.Text;
				ucBasket.Update();
				return ucBasket;
			}
			else
			{
				foreach (Control c in ms.panelBasket.Controls)
				{
					if (c is ucBasket)
					{
						if (((ucBasket)c).FoodID == id )
						{
							((ucBasket)c).QTY++;
							((ucBasket)c).Update();
						}

					}
				}

			}
			return null;

		}

		private int CheckID(int id)
		{
			int foundId = -1;
			foreach (int foodId in MS.foodIDList)
			{
				if(foodId == id)
				{
					foundId = foodId;
					break;
				}
			}
			return foundId;
		}
	}
}
