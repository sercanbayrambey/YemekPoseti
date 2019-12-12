using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

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
		private DB db { get;  set; }

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
