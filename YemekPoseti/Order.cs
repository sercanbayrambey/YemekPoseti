using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
    class Order
    {
        public Basket Basket { get; private set; }
        public User LoggedUser { get; private set; }
        public Restaurant SelectedRestaurant { get; private set; }
        public string Adress { get; private set; }

        public int currentOrderID;

        public int uniqueKey;

        private DB db = new DB();

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

        public Order(Basket basket, User loggedUser,Restaurant restaurant,string adress)
        {
            this.Basket = basket;
            this.LoggedUser = loggedUser;
            this.Adress = adress;
            this.SelectedRestaurant = restaurant;
            GenerateUniqueKey();
        }

     
        public bool SendOrderToServer()
        {
            string query = String.Format("INSERT INTO Orders(UserID, RestaurantID, OrderDate, Status, UniqueKey) VALUES('{0}', '{1}', '{2}','{3}','{4}')", LoggedUser.UserID, SelectedRestaurant.ID, DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"),0,uniqueKey);
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
                foreach (ucBasketItem item in this.Basket.FoodsInOrder)
                {
                    query = String.Format("INSERT INTO Basket (FoodID, OrderQTY, unitPrice,OrderID) VALUES('{0}', '{1}', '{2}','{3}' )", item.FoodID, item.QTY, item.Price,currentOrderID);
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
