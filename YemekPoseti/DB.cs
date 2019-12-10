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
			{"db", "u247404070_yemekposeti" },
			{"user", "u247404070_sercan" },
			{"pass", "yemekposeti123" }
		};
		private MySqlConnection con;
		private MySqlCommand cmd;
		private MySqlDataReader rd;


		public void Connect()
		{
			this.con = new MySqlConnection("Server=" + config["host"] + ";Database=" + config["db"] + ";Uid=" + config["user"] + ";Pwd=" + config["pass"] + ";");

			try
			{
				this.con.Open();
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
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


		public void Close()
		{

			con.Close();
		}
	}
}
