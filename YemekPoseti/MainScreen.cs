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
        private Restaurant SelectedRestaurant;
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
            TabMain.TabPages.Remove(TabPageOrder);
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

        private void Restaurant_Click(object sender, EventArgs e)
        {
            ucRestList ucTemp;
            if (sender is ucRestList)
            {
                ucTemp = (ucRestList)sender;
            }
            else
            {
                Control control =(Control)sender;
                ucTemp = (ucRestList)control.Parent;
            }

            LoadSelectedRestaurant(ucTemp);
            ShowOrderScreen();
        }

        private void LoadSelectedRestaurant(ucRestList ucTemp)
        {
            SelectedRestaurant = null;
            SelectedRestaurant = new Restaurant();
            SelectedRestaurant.ID = ucTemp.RestID;
            SelectedRestaurant.LocationID = ucTemp.LocationID;
            SelectedRestaurant.Name = ucTemp.lblRestName.Text;
            SelectedRestaurant.MinOrderPrice = ucTemp.MinOrderPrice;
            SelectedRestaurant.OwnerID = ucTemp.OwnerID;
            SelectedRestaurant.Rating = Convert.ToSingle(ucTemp.bgRestRating.Text);
            SelectedRestaurant.Description = ucTemp.lblRestDesc.Text;
        }


        private void ShowOrderScreen()
        {
            if(!TabMain.TabPages.Contains(TabPageOrder))
                TabMain.TabPages.Add(TabPageOrder);
            TabMain.SelectedTab = TabPageOrder;
            lblOrderRestName.Text = SelectedRestaurant.Name;
            panelFoodMenu.Controls.Clear();
            ShowFoodList();
        }

        private void ShowFoodList()
        {
            if(db.Connect())
            {
                int j = 0;
                string query = string.Format("SELECT * FROM Foods WHERE RestaurantID = '{0}'", SelectedRestaurant.ID);
                MySqlDataReader dr = db.GetQuery(query);
                while (dr.Read())
                {
                    panelFoodMenu.Controls.Add(SelectedRestaurant.GetFoodList(dr,j));
                    j++;
                }
                db.Close();
            }
            else
            {
                MessageBox.Show("Uzak sunucuya bağlanılamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void AddRestaurantsToList()
		{
            db.Connect();
            int r, g;
            //Red = 180 - GREEN;
            //Green = Rating*18;
            int restaurantRating;
            int j = 0;
            string query = string.Format("SELECT * FROM Restaurants WHERE LocationID = '{0}' ORDER BY RestaurantRating ASC",LoggedUser.LocationID);
            MySqlDataReader dr = db.GetQuery(query);
            while(dr.Read())
            {
                ucRestList ucTemp = new ucRestList();

                /* Event Controls */
                ucTemp.Click += new EventHandler(Restaurant_Click);
                foreach (Control c in ucTemp.Controls)
                {
                    c.Click += new EventHandler(Restaurant_Click);
                }

                /* BG Color */
                if (j % 2 == 0)
                    ucTemp.BackColor = Color.FromArgb(255, 245, 255);

                /* Dock Setting */
                ucTemp.Dock = DockStyle.Top;
                
                restaurantRating = Convert.ToInt32(dr["RestaurantRating"]);
                /* Dynamic Rating Color */
                g = restaurantRating * 18;
                r = 180 - g;
                ucTemp.bgRestRating.BackColor = Color.FromArgb(r, g, 0);

                /* Set */
                ucTemp.lblRestDesc.Text = dr["RestaurantDesc"].ToString();
                ucTemp.lblRestName.Text = dr["RestaurantName"].ToString();
                ucTemp.RestID = Convert.ToInt32(dr["RestaurantID"]);
                ucTemp.LocationID = Convert.ToInt32(dr["LocationID"]);
                ucTemp.OwnerID = Convert.ToInt32(dr["UserID"]);
                ucTemp.bgRestRating.Location = new Point(ucTemp.lblRestName.Location.X + 10 + ucTemp.lblRestName.Width, ucTemp.bgRestRating.Location.Y);
                ucTemp.bgRestRating.Text = (Convert.ToSingle(dr["RestaurantRating"])).ToString("0.0");
                ucTemp.MinOrderPrice = Convert.ToSingle(dr["MinOrderPrice"]);
                ucTemp.lblMin.Text += " " + (ucTemp.MinOrderPrice).ToString("0.00") + " TL"; 
                panelRestourant.Controls.Add(ucTemp);
                j++;
            }
            db.Close();
		}

	}
	
}
