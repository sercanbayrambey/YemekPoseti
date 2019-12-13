using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
		private readonly User LoggedUser;
        private readonly DB db;
        public MainScreen(User user)
        {
			LoggedUser = user;
            db = new DB();
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
            this.BringToFront();
			this.Text = "HOŞGELDİN, " + LoggedUser.UserName.ToUpper() + "!";
			LoadProfileData();
            AddRestaurantsToList();
        }

		private void LoadProfileData()
		{
			lblUsername.Text = LoggedUser.UserName.ToUpper();
			lblCity.Text = LoggedUser.Location;
			lblDate.Text = LoggedUser.RegisterDate.ToShortDateString();
		}

		private void TabPageHome_Click(object sender, EventArgs e)
		{

		}

		private void AddRestaurantsToList()
		{
            db.Connect();
            int r, g;
            //Red = 180 - GREEN;
            //Green = Rating*18;
            int restaurantRating;
            int j = 0;
            string query = string.Format("SELECT RestaurantName,RestaurantDesc,RestaurantRating,MinSiparisTL FROM Restaurants WHERE LocationID = '{0}' ORDER BY RestaurantRating ASC",LoggedUser.LocationID);
            MySqlDataReader dr = db.GetQuery(query);
            while(dr.Read())
            {
                ucRestList ucTemp = new ucRestList();
                if (j % 2 == 0)
                    ucTemp.BackColor = Color.FromArgb(255, 245, 255);
                ucTemp.Dock = DockStyle.Top;
                restaurantRating = Convert.ToInt32(dr["RestaurantRating"]);
                g = restaurantRating * 18;
                r = 180 - g;
                ucTemp.bgRestRating.BackColor = Color.FromArgb(r, g, 0);
                ucTemp.lblRestDesc.Text = dr["RestaurantDesc"].ToString();
                ucTemp.lblRestName.Text = dr["RestaurantName"].ToString();
                ucTemp.bgRestRating.Location = new Point(ucTemp.lblRestName.Location.X + 10 + ucTemp.lblRestName.Width, ucTemp.bgRestRating.Location.Y);
                ucTemp.bgRestRating.Text = (Convert.ToSingle(dr["RestaurantRating"])).ToString("0.0");
                ucTemp.lblMin.Text += " " + (Convert.ToSingle(dr["MinSiparisTL"])).ToString("0.00") + " TL"; 
                panelRestourant.Controls.Add(ucTemp);
                j++;
            }
            db.Close();
   
		}

	}
	
}
