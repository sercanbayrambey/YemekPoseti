using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
	public class DB
	{
		private static Dictionary<string, string> config = new Dictionary<string, string>() {
			{"host", "sql290.main-hosting.eu" },
			{"db", "u247404070_yemekposeti" },
			{"user", "u247404070_sercan" },
			{"pass", "yemekposeti123" }
		};
		private MySqlConnection con;
		private MySqlCommand cmd;
		private MySqlDataReader rd;

		public bool Connect()
		{
			this.con = new MySqlConnection("Server=" + config["host"] + ";Database=" + config["db"] + ";Uid=" + config["user"] + ";Pwd=" + config["pass"] + ";");

			try
			{
				this.con.Open();
				return true;
			}

			catch (Exception e)
			{
				return false;
			}
		}

		public int SetQuery(string query)
		{

			cmd = new MySqlCommand(query, con);

			try
			{
				return cmd.ExecuteNonQuery();
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return 0;
			}
		}

		public MySqlDataReader GetQuery(string query)
		{
			try
			{
				cmd = new MySqlCommand(query, con);
				rd = cmd.ExecuteReader();
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			return rd;

		}

		public List<string> GetCities()
		{
			this.Connect();
			List<string> cityList = new List<string>();
			string query = "SELECT LocationName FROM Locations";
			MySqlDataReader dr = this.GetQuery(query);
			while (dr.Read())
			{
				cityList.Add(dr["LocationName"].ToString());
			}
			this.Close();
			return cityList;
		}


		public int CityToLocationID(string city)
		{
			int cityID = 0;
			string query = string.Format("SELECT LocationID From Locations WHERE LocationName = '{0}'",city);
			this.Connect();
			MySqlDataReader dr = this.GetQuery(query);
			if(dr.Read())
			{
				cityID = Convert.ToInt32(dr["LocationID"]);
			}
			this.Close();
			return cityID;
		}

		public void Close()
		{
			con.Close();
		}
	}
}
