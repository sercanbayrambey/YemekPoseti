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
	}
}
