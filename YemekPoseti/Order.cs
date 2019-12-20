using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace YemekPoşeti
{
  class Order
    {
        public Basket Basket { get; private set; }
        public User LoggedUser { get; private set; }
        public Restaurant SelectedRestaurant { get; private set; }
        private readonly DB db;
        private MainScreen ms;
        public float SumBasketPrice { get; set; }
        public float DiscountPrice { get; set; }
        public float FinalPrice { get; set; }
        public float MinOrderPrice { get; set; }
        public string Adress { get;  set; }


        private float DiscountPercantage = 5;
        private int currentOrderID;
        private int uniqueKey;
        public Order(User loggedUser,Restaurant restaurant, MainScreen ms)
        {
            this.Basket = new Basket();
            this.LoggedUser = loggedUser;
            this.SelectedRestaurant = restaurant;
            this.ms = ms;
            this.db = new DB();
            GenerateUniqueKey();
        }

        public void GetSumBasketPrice()
        {
            SumBasketPrice = 0;
            foreach (ucBasketItem ucbasket in this.Basket.FoodsInBasket)
            {
                SumBasketPrice += (ucbasket.QTY * ucbasket.Price);
            }
            DiscountPrice = Convert.ToSingle(Math.Round((SumBasketPrice * DiscountPercantage) / 100, 2));
            FinalPrice = SumBasketPrice - DiscountPrice;
        }


        public void CheckRestMinPriceStatus()
        {
            if (this.FinalPrice >= this.MinOrderPrice)
            {
                ms.lblMinPriceWarn.Visible = false;
                ms.btnOrder.Enabled = true;

            }
            else
            {
                ms.lblMinPriceWarn.Text = String.Format("Minimum sipariş tutarı {0} TL olmalıdır!", this.MinOrderPrice);
                ms.lblMinPriceWarn.Visible = true;
                ms.btnOrder.Enabled = false;
            }
        }
        public void PrintFoods(ListBox lbox)
        {
            lbox.Items.Clear();
            foreach (ucBasketItem food in this.Basket.FoodsInBasket)
            {
                if (food.QTY > 0)
                    lbox.Items.Add(food.FoodName + " (" + food.QTY + " Adet)");
            }
        }
        public bool GenerateUniqueKey()
        {
            db.Connect();
            Random rnd = new Random();
            uniqueKey = rnd.Next(0, 9000000);
            string query = String.Format("SELECT UniqueKey FROM Orders WHERE UniqueKey = '{0}'",uniqueKey);
            MySqlDataReader dr = db.GetQuery(query);
            if (dr.Read())
            {
                db.Close();
                GenerateUniqueKey();
            }
            db.Close();
            return true;
        }
        public bool SendOrderToServer()
        {
            string query = String.Format("INSERT INTO Orders(UserID, RestaurantID, OrderDate, StatusID, UniqueKey, Adress,FinalPrice) VALUES('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}')", LoggedUser.UserID, SelectedRestaurant.ID, DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"), 1, this.uniqueKey, this.Adress, this.FinalPrice.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)); 
            if (db.Connect())
            {
        
                if (db.SetQuery(query) > 0)
                {
                    db.Close();
                    return true;
                }
                else
                {
                    db.Close();
                    return false;
                }
            }
            else
                return false;
        }
        private bool GetOrderID()
        {
            MySqlDataReader dr;
            string query = String.Format("SELECT OrderID FROM Orders WHERE UniqueKey = '{0}'", uniqueKey);
            db.Connect();
           dr = db.GetQuery(query);
            if (dr.Read())
            {
                currentOrderID = Convert.ToInt32(dr["OrderID"]);
                db.Close();
                return true;
            }
           else
            {
                db.Close();
                return false;
            }
        }
        public bool SendBasketToServer()
        {
            string query;
            if(GetOrderID() && db.Connect())
            {
                foreach (ucBasketItem item in this.Basket.FoodsInBasket)
                {
                    query = String.Format("INSERT INTO Basket (FoodID, QTY, unitPrice,OrderID) VALUES('{0}', '{1}', '{2}','{3}' )", item.FoodID, item.QTY, item.Price,currentOrderID);
                    db.SetQuery(query);
                }
            }
            else
                return false;
            db.Close();
            return true;
        }
    }
}
