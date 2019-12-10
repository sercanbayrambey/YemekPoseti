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
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Pass { get; set; }
		public string Mail { get; set; }
		public string Location { get; set; }
		public int UserType { get; set; }
		public DateTime RegisterDate { get; set; }
		public DB db { get; set; }

		
		public User() // Login
		{
			this.db = new DB();
		}

		public bool Login(string username, string pass)
		{
			string query = string.Format("SELECT * FROM Users WHERE UserName = '{0}' AND UserPassword = '{1}'", username.ToLower(), pass);
			db.Connect();
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


		public bool Register(string username,string pass, string email)
		{

			if (IsRegistered(username, email))
				return false;

			string query = string.Format("INSERT INTO Users(UserName,UserPassword,UserMail)" +
				" VALUES ( '{0}','{1}','{2}' )", username.ToLower(), pass, email);
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
				RegisterDate = Convert.ToDateTime(dr["UserRegisterDate"]);
				UserType = Convert.ToInt32(dr["UserType"]);
				db.Close();
			}

		}


		public override string ToString()
		{
			return this.Mail + " " + this.Location + " " + this.UserName + " " + this.UserType + " " + this.UserID;
		}












	}
}
