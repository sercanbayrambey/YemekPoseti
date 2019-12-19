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
		public ucFoodList ucFood;
		public Order CurrentOrder = new Order();
		public MainScreen(User user)
        {
			LoggedUser = user;
            db = new DB();
            InitializeComponent();
        }

		private void MainScreen_Load(object sender, EventArgs e)
		{
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
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


	
		private void Food_Click(object sender, EventArgs e)
		{
			if(!(sender is ucFoodList))
			{
				Control control = (Control)sender;
				ucFood = (ucFoodList)control.Parent;
				var x = ucFood.AddFoodToBasket(this);
				if (x != null)
				{
					x.ms = this;
					panelBasket.Controls.Add(x);
					CurrentOrder.FoodsInOrder.Add(x);
                }
                CurrentOrder.PrintFoods(lboxUrunler);
                CurrentOrder.GetSumPrice();
				lblSumPrice.Text = CurrentOrder.SumPrice.ToString("0.00") + " TL";
				lblSumDiscount.Text = CurrentOrder.DiscountPrice.ToString("0.00") + " TL"; ;
				lblFinalSumPrice.Text = (CurrentOrder.FinalPrice).ToString("0.00") + " TL";
			}
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
			panelBasket.Controls.Clear();
            lboxUrunler.Items.Clear();
            CurrentOrder = null;
            CurrentOrder = new Order();
            CurrentOrder.MinOrderPrice = SelectedRestaurant.MinOrderPrice;
			lblSumPrice.Text = "0,00 TL";
			lblFinalSumPrice.Text = "0,00 TL";
			lblSumDiscount.Text = "0,00 TL";
            lblMin.Text = "Min. Sipariş Tutarı: " + CurrentOrder.MinOrderPrice.ToString("0.00") + " TL";
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
					ucFood = SelectedRestaurant.GetFoodList(dr, j);
					ucFood.Click += new EventHandler(Food_Click);
					foreach (Control c in ucFood.Controls)
					{
						c.Click += new EventHandler(Food_Click);
					}
					panelFoodMenu.Controls.Add(ucFood);
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
            int j = 0;
            string query = string.Format("SELECT * FROM Restaurants WHERE LocationID = '{0}' ORDER BY RestaurantRating ASC",LoggedUser.LocationID);
            MySqlDataReader dr = db.GetQuery(query);
            while(dr.Read())
            {
                ucRestList ucTempRestList = new ucRestList(dr);
                /* Event Controls */
                ucTempRestList.Click += new EventHandler(Restaurant_Click);
                foreach (Control c in ucTempRestList.Controls)
                {
                    c.Click += new EventHandler(Restaurant_Click);
                }
                /* BG Color */
                if (j % 2 == 0)
                    ucTempRestList.BackColor = Color.FromArgb(255, 245, 255);
                panelRestourant.Controls.Add(ucTempRestList);
                j++;
            }
            db.Close();
		}

		private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void panelFoodMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelBasket_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
	
}
