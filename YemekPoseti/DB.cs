using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
	class DB
	{
		private static Dictionary<string, string> config = new Dictionary<string, string>() {
			{"host", "sql290.main-hosting.eu" },
			{"user", "u247404070_yemekposeti" },
			{"pass", "u247404070_sercan" },
			{"db", "yemekposeti123" }
		};
		private DB connect = null;
		private MySqlConnection con;
		private MySqlCommand cmd = new MySqlCommand();
		/*
		MySqlConnection con = new MySqlConnection("Server=sql290.main-hosting.eu;Database=u247404070_yemekposeti;Uid=u247404070_sercan;Pwd='yemekposeti123';");
		MySqlCommand cmd = new MySqlCommand();
		cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT LocationName FROM Locations";
            MySqlDataReader dr = cmd.ExecuteReader();
		*/
		public DB()
		{
			con = new MySqlConnection("Server=" + config["host"] + ";Database=" + config["db"] + ";Uid=" + config["user"] + ";Pwd=" + config["pass"] + ";");
		}

		public DB Connect()
		{
			if (connect == null)
			{
				this.connect = new DB();
			}
			return this.connect;
		}
	}
}
