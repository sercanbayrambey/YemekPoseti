using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekPoşeti
{
    class Restaurant
    {
        public int ID{ get; set; }

        public int OwnerID { get; set; }

        public string Name { get; set; }
        public int LocationID { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public float MinOrderPrice { get; set; }
        private DB db;
        private MainScreen ms;


        public Restaurant(MainScreen ms)
        {
            this.ms = ms;
        }




        public List<ucFoodItem> GetFoodList()
        {
            db = new DB();
            List<ucFoodItem> FoodList = new List<ucFoodItem>();
            if (db.Connect())
            {
                int j = 0;
                string query = string.Format("SELECT * FROM Foods WHERE RestaurantID = '{0}'", this.ID);
                MySqlDataReader dr = db.GetQuery(query);
                while (dr.Read())
                {
                    ucFoodItem ucTempFoodList = new ucFoodItem(dr);
                    if (j % 2 == 0)
                        ucTempFoodList.BackColor = Color.FromArgb(255, 245, 255);
                    FoodList.Add(ucTempFoodList);
                    j++;
                }
                db.Close();
                return FoodList;
            }
            else
                return FoodList;
        }

        public List<ucRM_MenuItem> GetOwnedRestFoodList()
        {
            db = new DB();
            List<ucRM_MenuItem> FoodList = new List<ucRM_MenuItem>();
            if (db.Connect())
            {
                int j = 0;
                string query = string.Format("SELECT * FROM Foods WHERE RestaurantID = '{0}'", this.ID);
                MySqlDataReader dr = db.GetQuery(query);
                while (dr.Read())
                {
                    ucRM_MenuItem ucTempFoodList = new ucRM_MenuItem(dr,this);
                    if (j % 2 == 0)
                        ucTempFoodList.BackColor = Color.FromArgb(255, 245, 255);
                    FoodList.Add(ucTempFoodList);
                    j++;
                }
                db.Close();
                return FoodList;
            }
            else
                return FoodList;
        }


        public void GetProperties(int id)
        {
            db = new DB();
            db.Connect();
            this.OwnerID = id;
            string query = String.Format("SELECT * FROM Restaurants WHERE UserID = {0}", this.OwnerID);
            MySqlDataReader dr = db.GetQuery(query);
             
            //set
            if(dr.Read())
            {
                this.ID = Convert.ToInt32(dr["RestaurantID"]);
                this.Name = dr["RestaurantName"].ToString();
                this.LocationID = Convert.ToInt32(dr["LocationID"]);
                this.Rating = Convert.ToSingle(dr["RestaurantRating"]);
                this.MinOrderPrice = Convert.ToSingle(dr["MinOrderPrice"]);
            }
            db.Close();
        }
        public bool SaveProperties(string name, string minOrderPrice, int locationID)
        {
            db = new DB();
            db.Connect();
            this.Name = name;
            this.MinOrderPrice = Convert.ToSingle(minOrderPrice);
            this.LocationID = locationID;

            string query = String.Format("UPDATE Restaurants SET RestaurantName = '{0}', LocationID = {1}," +
                " MinOrderPrice = '{2}' WHERE RestaurantID = {3} ", this.Name, this.LocationID, minOrderPrice, this.ID);

            if(db.SetQuery(query)>0)
            {
                db.Close();
                return true;
            }
            db.Close();
            return false;
        }


        public bool AddFoodToMenu(string name, string foodDesc, string foodPrice)
        {
            db = new DB();
            db.Connect();
            string query = String.Format("INSERT INTO Foods (FoodName,FoodPrice,FoodDesc,FoodCategoryID,RestaurantID)" +
                "VALUES('{0}','{1}','{2}',1,{3})", name, foodPrice, foodDesc, this.ID);

            if (db.SetQuery(query) > 0)
            {
                db.Close();
                return true;
            }
            db.Close();
            return false;

        }

        public bool DeleteFood(int id)
        {
            db = new DB();
            db.Connect();
            string query = String.Format("DELETE FROM Foods WHERE FoodID = {0}",id);

            if (db.SetQuery(query) > 0)
            {
                ms.GetOwnedRestaurantInfo();
                db.Close();
                return true;
            }
            db.Close();
            return false;

        }

        public bool EditFood(int id, string name, string foodDesc, string foodPrice)
        {
            db = new DB();
            db.Connect();
            string query = String.Format("UPDATE Foods SET FoodName = '{0}',FoodDesc = '{1}', FoodPrice = {2} WHERE FoodID = {3}",name,foodDesc,foodPrice,id);

            if (db.SetQuery(query) > 0)
            {
                ms.GetOwnedRestaurantInfo();
                db.Close();
                return true;
            }
            db.Close();
            return false;
        }


        public List<ucRMOrders> GetOrders()
        {
            MySqlDataReader dr;
            int orderID = -1;
            int status;
            List<ucRMOrders> pastOrderList = new List<ucRMOrders>();
            string query = string.Format("SELECT U.UserName,O.Adress,O.OrderID,O.OrderDate,F.FoodName,R.RestaurantName,O.StatusID,OS.Status,L.LocationName,O.FinalPrice, B.QTY FROM Orders O" +
                                        " INNER JOIN Basket B ON B.OrderID = O.OrderID" +
                                        " INNER JOIN Restaurants R ON R.RestaurantID = O.RestaurantID" +
                                        " INNER JOIN Foods F ON F.FoodID = B.FoodID" +
                                        " INNER JOIN Locations L ON L.LocationID = R.LocationID" +
                                        " INNER JOIN Users U ON O.UserID = U.UserID" +
                                        " INNER JOIN OrderStatus OS ON O.StatusID = OS.StatusID WHERE R.RestaurantID = {0}" +
                                        " ORDER BY O.OrderID ASC", this.ID);
            db.Connect();
            dr = db.GetQuery(query);
            ucRMOrders ucOrderFood = new ucRMOrders(this);
            while (dr.Read())
            {

                if (orderID != Convert.ToInt32(dr["OrderID"]))
                {
                    orderID = Convert.ToInt32(dr["OrderID"]);
                    ucOrderFood  = new ucRMOrders(this);
                    ucOrderFood.orderID = Convert.ToInt32(dr["OrderID"]);
                    ucOrderFood.Dock = System.Windows.Forms.DockStyle.Top;
                    ucOrderFood.lblFoodPrice.Text = (Convert.ToSingle(dr["FinalPrice"])).ToString("0.00") + " TL";
                    ucOrderFood.lboxFoods.Items.Add(dr["FoodName"].ToString() + " (x" + dr["QTY"].ToString() + ")");
                    ucOrderFood.lblAdress.Text = dr["Adress"].ToString();
                    status = Convert.ToInt32(dr["StatusID"]);
                    ucOrderFood.lblDate.Text = Convert.ToDateTime(dr["OrderDate"]).ToString("dd/MM/yyyy\nHH:mm");
                    ucOrderFood.lblStatus.Text = dr["Status"].ToString();
                    ucOrderFood.lblCustomerName.Text = dr["UserName"].ToString();
                    switch (status)
                    {
                        case 1: // Delivered to restaurant
                            ucOrderFood.BackColor = Color.FromArgb(190, 255, 190);
                            ucOrderFood.lblStatus.ForeColor = Color.Green;
                            ucOrderFood.btnPreparing.Enabled = true;
                            ucOrderFood.btnDelivered.Enabled = true;
                            ucOrderFood.btnCancelOrder.Enabled = true;
                            ucOrderFood.lblStatus.Text = "Yeni sipariş!";
                            break;
                        case 2://Order is preparing
                            ucOrderFood.BackColor = Color.FromArgb(255, 245, 255);
                            ucOrderFood.lblStatus.ForeColor = Color.DarkMagenta;
                            ucOrderFood.btnPreparing.Enabled = false;
                            ucOrderFood.btnDelivered.Enabled = true;
                            ucOrderFood.btnCancelOrder.Enabled = true;
                            ucOrderFood.lblStatus.Text = "Hazırlanıyor...";
                            break;
                        case 3://Order delivered to customer
                            ucOrderFood.BackColor = Color.White;
                            ucOrderFood.lblStatus.ForeColor = Color.Black;
                            ucOrderFood.lblFoodPrice.ForeColor = Color.Black;
                            ucOrderFood.btnPreparing.Enabled = true;
                            ucOrderFood.btnDelivered.Enabled = false;
                            ucOrderFood.btnCancelOrder.Enabled = true;
                            ucOrderFood.lblStatus.Text = "Teslim edildi.";
                            break;
                        case 4:// order canceled by restaurant
                            ucOrderFood.BackColor = Color.FromArgb(240, 240, 240);
                            ucOrderFood.lblFoodPrice.ForeColor = Color.Gray;
                            ucOrderFood.lblDate.ForeColor = Color.Gray;
                            ucOrderFood.lblStatus.ForeColor = Color.Red;
                            ucOrderFood.btnPreparing.Enabled = true;
                            ucOrderFood.btnDelivered.Enabled = true;
                            ucOrderFood.btnCancelOrder.Enabled = false;
                            ucOrderFood.lblStatus.Text = "İptal edildi !";
                            break;
                    }
                    pastOrderList.Add(ucOrderFood);
                }
                else
                {
                    ucOrderFood.lboxFoods.Items.Add(dr["FoodName"].ToString() + " (x" + dr["QTY"] + ")");
                }
            }
            db.Close();
            return pastOrderList;
        }

        public void SetOrderState(int orderID,int state)
        {
            db = new DB();
            db.Connect();
            string query = String.Format("UPDATE Orders SET StatusID = {0} WHERE OrderID = {1}",state,orderID);
			if (db.SetQuery(query) > 0)
				ms.ShowOwnedRestOrders();

        }

    }
}
