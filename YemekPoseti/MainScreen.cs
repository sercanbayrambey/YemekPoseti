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
            int j = 0;
            string query = string.Format("SELECT RestaurantName,RestaurantDesc FROM Restaurants WHERE LocationID = '{0}'",LoggedUser.LocationID);
            MySqlDataReader dr = db.GetQuery(query);
            while(dr.Read())
            {
                ucRestList ucTemp = new ucRestList();
                if (j % 2 == 0)
                    ucTemp.BackColor = Color.FromArgb(255, 245, 255);
                ucTemp.Dock = DockStyle.Top;
                ucTemp.lblRestDesc.Text = dr["RestaurantDesc"].ToString();
                ucTemp.lblRestName.Text = dr["RestaurantName"].ToString();
                panelRestourant.Controls.Add(ucTemp);
                j++;
            }
            db.Close();
   
		}

	}
	
}
