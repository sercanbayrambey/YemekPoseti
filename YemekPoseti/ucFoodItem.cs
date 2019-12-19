using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace YemekPoşeti
{
    public partial class ucFoodItem : UserControl
	{
		public int FoodID { get; set; }
		public float Price { get; set; }
		private MainScreen MS;
		
        public ucFoodItem(MySqlDataReader dr)
        {
            InitializeComponent();
            /* Dock Setting */
            this.Dock = DockStyle.Top;
            /* Set */
            this.lblFoodName.Text = dr["FoodName"].ToString();
            this.lblFoodDesc.Text = dr["FoodDesc"].ToString();
            this.FoodID = Convert.ToInt32(dr["FoodID"]);
            this.Price = (Convert.ToSingle(dr["FoodPrice"]));
            this.lblFoodPrice.Text = this.Price.ToString("0.00") + " TL";
        }

		private void ucFoodList_Load(object sender, EventArgs e)
		{
			
		}

		public ucBasketItem AddFoodToBasket(MainScreen ms)
		{
			MS = ms;
			int id = CheckID(FoodID);
			if (id == -1)
			{
				ucBasketItem ucBasket = new ucBasketItem();
				MS.CurrentBasket.foodIDList.Add(this.FoodID);
				ucBasket.Dock = DockStyle.Top;
				ucBasket.FoodID = this.FoodID;
				ucBasket.Price = this.Price;
				ucBasket.FoodName = this.lblFoodName.Text;
				ucBasket.FoodDesc = this.lblFoodDesc.Text;
                ucBasket.ms = ms;
				ucBasket.Update();

				return ucBasket;
			}
			else
			{
				foreach (Control c in ms.panelBasket.Controls)
				{
					if (c is ucBasketItem)
					{
						if (((ucBasketItem)c).FoodID == id )
						{
							((ucBasketItem)c).QTY++;
							((ucBasketItem)c).Update();
						}

					}
				}

			}
			return null;

		}

		private int CheckID(int id)
		{
			int foundId = -1;
			foreach (int foodId in MS.CurrentBasket.foodIDList)
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
