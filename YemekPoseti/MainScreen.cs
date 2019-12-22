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
     partial class MainScreen : MetroFramework.Forms.MetroForm
    {
		private readonly User LoggedUser;
        private readonly DB db;
        private Restaurant SelectedRestaurant;
        public ucFoodItem ucFood;
        public Order CurrentOrder;
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
			TabMain.TabPages.Remove(TabPageOrder);
			LoadProfileData();
			this.Text = "HOŞGELDİN, " + LoggedUser.UserName.ToUpper() + "!";
			AddRestaurantsToList();
            ShowPastOrders();
            TabMain.SelectedIndex = 0;
        }

		private void LoadProfileData()
		{
			lblUsername.Text = LoggedUser.UserName.ToUpper();
			lblCity.Text = LoggedUser.Location;
			lblDate.Text = LoggedUser.RegisterDate.ToShortDateString();
		}

        private void Restaurant_Click(object sender, EventArgs e)
        {
            ucRestList ucTempRestourantItem;
            if (sender is ucRestList)
            {
                ucTempRestourantItem = (ucRestList)sender;
            }
            else
            {
                Control control =(Control)sender;
                ucTempRestourantItem = (ucRestList)control.Parent;
            }

            LoadSelectedRestaurant(ucTempRestourantItem);
            ShowOrderScreen();
        }


	
		private void Food_Click(object sender, EventArgs e)
		{

			if(!(sender is ucFoodItem))
			{
				Control control = (Control)sender;
				ucFood = (ucFoodItem)control.Parent;
				var x = CurrentOrder.Basket.AddFood(ucFood,this);
				if (x != null)
					panelBasket.Controls.Add(x);

                lblSumPrice.Text = CurrentOrder.SumBasketPrice.ToString("0.00") + " TL";
				lblSumDiscount.Text = CurrentOrder.DiscountPrice.ToString("0.00") + " TL"; ;
				lblFinalSumPrice.Text = (CurrentOrder.FinalPrice).ToString("0.00") + " TL";
			}
		}

        private void LoadSelectedRestaurant(ucRestList ucTemp)
        {
            SelectedRestaurant = new Restaurant
            {
                ID = ucTemp.RestID,
                LocationID = ucTemp.LocationID,
                Name = ucTemp.lblRestName.Text,
                MinOrderPrice = ucTemp.MinOrderPrice,
                OwnerID = ucTemp.OwnerID,
                Rating = Convert.ToSingle(ucTemp.bgRestRating.Text),
                Description = ucTemp.lblRestDesc.Text
            };
        }

        private void ShowPastOrders()
        {
            panelPastOrders.Controls.Clear();
            List<ucPastOrderItem> pastOrderItems = new List<ucPastOrderItem>();
            pastOrderItems = LoggedUser.GetPastOrders();
            foreach (ucPastOrderItem item in pastOrderItems)
            {
                panelPastOrders.Controls.Add(item);
            }
        }
        private void ShowOrderScreen()
        {
            CurrentOrder = new Order(LoggedUser,SelectedRestaurant,this);
            if(!TabMain.TabPages.Contains(TabPageOrder))
                TabMain.TabPages.Add(TabPageOrder);
            TabMain.SelectedTab = TabPageOrder;
            lblOrderRestName.Text = SelectedRestaurant.Name + ", " + LoggedUser.Location ;
            CurrentOrder.MinOrderPrice = SelectedRestaurant.MinOrderPrice;
            lblSumPrice.Text = "0,00 TL";
            lblFinalSumPrice.Text = "0,00 TL";
            lblSumDiscount.Text = "0,00 TL";
            lblMin.Text = "Min. Sipariş Tutarı: " + CurrentOrder.MinOrderPrice.ToString("0.00") + " TL";
            panelFoodMenu.Controls.Clear();
            panelBasket.Controls.Clear();
            lboxUrunler.Items.Clear();
            CurrentOrder.CheckRestMinPriceStatus();
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
            lblRestList.Text = "Restoran Listesi" + " (" + LoggedUser.Location + ")";
            panelRestourant.Controls.Clear();
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

        private void tboxAdress_Enter(object sender, EventArgs e)
        {
            string defaultText = "Adresinizi giriniz...";
            if (tboxAdress.Text.Equals(defaultText))
                tboxAdress.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string defaultAdressText = "Adresinizi giriniz...";
            btnOrder.Enabled = false;
            CurrentOrder.Adress = tboxAdress.Text.ToLower();
            if (tboxAdress.Text.Equals(defaultAdressText) || tboxAdress.Text.Length < 10)
            {
                btnOrder.Enabled = true;
                MessageBox.Show("Adres bölümü bu kadar kısa olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxAdress.Select();
                return;
            }

            if (CurrentOrder.SendOrderToServer() && CurrentOrder.SendBasketToServer())
            {
                MessageBox.Show("Siparişiniz başarıyla alınmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrder.Enabled = true;
                ShowPastOrders();
                TabMain.TabPages.Remove(TabPageOrder);
                TabMain.SelectedIndex = 0;
            }
            else
            {
                btnOrder.Enabled = true;
                MessageBox.Show("Siparişiniz sırasında bir hata meydana geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPastOrders();
            AddRestaurantsToList();
        }



        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabMain.SelectedIndex == 0)
            {
                TabPageHome.Controls.Add(panelPastOrders);
                TabPageHome.Controls.Add(lblUserOrders);
                TabPageHome.Controls.Add(lblUserOrdersDesc);
                TabPageHome.Controls.Add(btnRefresh);
            }
            else if (TabMain.SelectedIndex == 1)
            {
                TabPageProfile.Controls.Add(panelPastOrders);
                TabPageProfile.Controls.Add(panelPastOrders);
                TabPageProfile.Controls.Add(lblUserOrders);
                TabPageProfile.Controls.Add(lblUserOrdersDesc);
                TabPageProfile.Controls.Add(btnRefresh);
            }
        }
    }
	
}
