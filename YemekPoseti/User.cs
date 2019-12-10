using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
	class User
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Pass { get; set; }
		public string Mail { get; set; }
		public string Location { get; set; }
		public int UserType { get; set; }
		public DateTime RegisterDate { get; set; }
		public DB db { get; set; }

		public User(string username,string pass)
		{
			this.UserName = username;
			this.Pass = pass;
			this.db = new DB();
			GetUserInfo();
		}

		private void GetUserInfo()
		{
			string query = string.Format("SELECT * FROM Users WHERE UserName = '{0}' AND UserPassword = '{1}'", UserName.ToLower(), Pass);
			db.Connect();
			MySqlDataReader dr =  db.GetQuery(query);
			if(dr.Read())
			{
				UserID = Convert.ToInt32(dr["UserID"]);
				Mail = dr["UserMail"].ToString();
				RegisterDate = Convert.ToDateTime(dr["UserRegisterDate"]);
				UserType = Convert.ToInt32(dr["UserID"]);
				db.Close();
			}

			db.Connect();
			query = string.Format("SELECT L.LocationName FROM Users U INNER JOIN Locations L ON U.LocationID = L.LocationID WHERE U.UserName = '{0}' AND U.UserPassword = '{1}'", UserName.ToLower(), Pass);
			dr = db.GetQuery(query);

			if(dr.Read())
				Location = dr["LocationName"].ToString();
			db.Close();
		}


		public override string ToString()
		{
			return this.Mail + " " + this.Location + " " + this.UserName + " " + this.UserType + " " + this.UserID;
		}












	}
}
