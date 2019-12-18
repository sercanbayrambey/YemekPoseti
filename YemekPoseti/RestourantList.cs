using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace YemekPoşeti
{
	public partial class ucRestList : UserControl
	{
        public int RestID { get; set; }
        public int LocationID { get; set; }
        public int OwnerID { get; set; }
        public float MinOrderPrice { get; set; }


		public ucRestList(MySqlDataReader dr)
		{
            int restRating, g, r;
			InitializeComponent();
            /* Dock Setting */
            this.Dock = DockStyle.Top;
            restRating = Convert.ToInt32(dr["RestaurantRating"]);
            /* Dynamic Rating Color */
            g = restRating * 18;
            r = 180 - g;
            this.bgRestRating.BackColor = Color.FromArgb(r, g, 0);

            /* Set */
            this.lblRestDesc.Text = dr["RestaurantDesc"].ToString();
            this.lblRestName.Text = dr["RestaurantName"].ToString();
            this.RestID = Convert.ToInt32(dr["RestaurantID"]);
            this.LocationID = Convert.ToInt32(dr["LocationID"]);
            this.OwnerID = Convert.ToInt32(dr["UserID"]);
            this.bgRestRating.Location = new Point(this.lblRestName.Location.X + 10 + this.lblRestName.Width, this.bgRestRating.Location.Y);
            this.bgRestRating.Text = (Convert.ToSingle(dr["RestaurantRating"])).ToString("0.0");
            this.MinOrderPrice = Convert.ToSingle(dr["MinOrderPrice"]);
            this.lblMin.Text += " " + (this.MinOrderPrice).ToString("0.00") + " TL";
        }


        private void ucRestList_Load(object sender, EventArgs e)
		{
            bgRestRating.FlatAppearance.BorderSize = 0;
        }

	}
}
