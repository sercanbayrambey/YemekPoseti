using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekPoşeti
{
	public partial class LoginScreen : MetroFramework.Forms.MetroForm
	{
		public LoginScreen()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            MySqlConnection con = new MySqlConnection("Server=sql290.main-hosting.eu;Database=u247404070_yemekposeti;Uid=u247404070_sercan;Pwd='yemekposeti123';");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT LocationName FROM Locations";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MessageBox.Show(dr["LocationName"].ToString());
            }
            con.Close();

        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
			MainScreen mainScreen = new MainScreen();
			this.Hide();
			mainScreen.ShowDialog();
			this.Close();
		}

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            string defaultText = "Kullanıcı adınız..";
            if (txtUserName.Text.Equals(defaultText))
            {
                txtUserName.Clear();
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            string defaultText = "Şifrenizi giriniz..";
            if (txtPass.Text.Equals(defaultText))
            {
                txtPass.Clear();
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
            }

            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
