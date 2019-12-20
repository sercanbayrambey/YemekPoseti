using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace YemekPoşeti
{
	public class User
	{
		public int UserID { get; private set; }
		public string UserName { get; private set; }
		public string Pass { get; private set; }
		public string Mail { get; private set; }
		public string Location { get; private set; }
		public int UserType { get; private set; }
		public DateTime RegisterDate { get; private set; }
        private DB db;

        public int LocationID { get; private set; }
		
		public User() // Login
		{
			this.db = new DB();
		}

		public bool Login(string username, string pass)
		{
			string query = string.Format("SELECT * FROM Users WHERE UserName = '{0}' AND UserPassword = '{1}'", username.ToLower(), pass);
			
			if(db.Connect())
			{
				MySqlDataReader dr = db.GetQuery(query);

				if (dr.Read())
				{
					//LOGIN TRUE
					this.UserID = Convert.ToInt32(dr["UserID"]);
					GetUserInfo();
					db.Close();
					return true;
				}
				db.Close();
				return false;
			}
			return false;
		}
		public bool Register(string username,string pass, string email,string city)
		{
			if (IsRegistered(username, email))
				return false;

			this.LocationID = db.CityToLocationID(city);
			string query = string.Format("INSERT INTO Users(UserName,UserPassword,UserMail,LocationID)" +
				" VALUES ( '{0}','{1}','{2}','{3}' )", username.ToLower(), pass, email,this.LocationID);
			db.Connect();
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

        public List<ucPastOrderItem> GetPastOrders()
        {
            MySqlDataReader dr;
            int orderID = -1;
            int status;
             Console.WriteLine(this.UserID);
            List<ucPastOrderItem> pastOrderList = new List<ucPastOrderItem>();
            string query = string.Format("SELECT O.OrderID,O.OrderDate,F.FoodName,R.RestaurantName,O.StatusID,OS.Status,L.LocationName,O.FinalPrice, B.QTY FROM Orders O" +
                                        " INNER JOIN Basket B ON B.OrderID = O.OrderID" +
                                        " INNER JOIN Restaurants R ON R.RestaurantID = O.RestaurantID" +
                                        " INNER JOIN Foods F ON F.FoodID = B.FoodID" +
                                        " INNER JOIN Locations L ON L.LocationID = R.LocationID"+
                                        " INNER JOIN OrderStatus OS ON O.StatusID = OS.StatusID WHERE O.UserID = '{0}'",this.UserID);
            db.Connect();
            dr = db.GetQuery(query);
            ucPastOrderItem ucPastOrder = new ucPastOrderItem();
            while(dr.Read())
            {
                
                if (orderID != Convert.ToInt32(dr["OrderID"]))
                {
                    orderID = Convert.ToInt32(dr["OrderID"]);
                    ucPastOrder = new ucPastOrderItem();
                    ucPastOrder.Dock = System.Windows.Forms.DockStyle.Top;
                    ucPastOrder.lblFoodPrice.Text = (Convert.ToSingle(dr["FinalPrice"])).ToString("0.00") + " TL"; 
                    ucPastOrder.lblRestName.Text = dr["RestaurantName"].ToString() +" (" + dr["LocationName"].ToString() + ", " + Convert.ToDateTime(dr["OrderDate"]).ToString("dd/MM/yyyy HH:mm") + ")";
                    ucPastOrder.lblFoods.Text = dr["FoodName"].ToString() +" (x" + dr["QTY"].ToString() +")";
                    status = Convert.ToInt32(dr["StatusID"]); 
                    ucPastOrder.lblStatus.Text = dr["Status"].ToString();
                    switch (status)
                    {
                        case 1:
                            ucPastOrder.BackColor = Color.White;
                            ucPastOrder.lblStatus.ForeColor = Color.DarkMagenta;
                            break;
                        case 2:
                            ucPastOrder.BackColor = Color.White;
                            ucPastOrder.lblStatus.ForeColor = Color.Green;
                            break;
                        case 3:
                            ucPastOrder.BackColor = Color.LavenderBlush;
                            ucPastOrder.lblStatus.ForeColor = Color.Black;
                            break;
                        case 4:
                            ucPastOrder.BackColor = Color.Gainsboro;
                            ucPastOrder.lblStatus.ForeColor = Color.Red;
                            break;

                    }
                    pastOrderList.Add(ucPastOrder);
                }
                else
                {
                    ucPastOrder.lblFoods.Text += ", " + dr["FoodName"].ToString() + " (x" + dr["QTY"] + ")"; ;
                }
            }
            db.Close();
            return pastOrderList;

        }



		private bool IsRegistered(string username,string email)
		{
			string query = string.Format("SELECT * FROM Users WHERE UserName = '{0}' OR UserMail = '{1}' ", username, email);
			db.Connect();
			MySqlDataReader dr =  db.GetQuery(query);
			if (dr.Read())
			{
				db.Close();
				return true;
			}
			db.Close();
			return false;
		}

		private void GetUserInfo()
		{
			string query = string.Format("SELECT * FROM Users U INNER JOIN Locations L ON U.LocationID = L.LocationID WHERE U.UserID = {0}", this.UserID);
			db.Connect();
			MySqlDataReader dr =  db.GetQuery(query);
			if(dr.Read())
			{
				UserName = dr["UserName"].ToString();
				Pass = dr["UserPassword"].ToString();
				Mail = dr["UserMail"].ToString();
				Location = dr["LocationName"].ToString();
                LocationID = Convert.ToInt32(dr["LocationID"]);
				RegisterDate = Convert.ToDateTime(dr["UserRegisterDate"]);
				UserType = Convert.ToInt32(dr["UserType"]);
				db.Close();
			}
			db.Close();
		}


		public override string ToString()
		{
			return this.Mail + " " + this.Location + " " + this.UserName + " " + this.UserType + " " + this.UserID;
		}
	}
}
