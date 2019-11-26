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
		private DB db = new DB();
		public LoginScreen()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			db.Connect();
			MySqlDataReader rd = db.GetQuery("SELECT LocationName FROM Locations");
		/*	while (rd.Read())
			{
				MessageBox.Show(rd["locationName"].ToString());
			}*/
            db.Close();

        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
            string username = txtUserName.Text;
            string pass = txtPass.Text;
            if (CheckLogin(username, pass))
            {
                /*MainScreen mainScreen = new MainScreen();
                this.Hide();
                mainScreen.ShowDialog();
                this.Close();*/
                MessageBox.Show("Giriş başarılı.");
            }
            else
                MessageBox.Show("Giriş başarısız!");
		}

        private bool CheckLogin(string username,string pass)
        {
            string query = string.Format("SELECT * FROM Users WHERE UserName = '{0}' and UserPassword = '{1}'", username.ToLower(), pass);
            db.Connect();
            MySqlDataReader dr = db.GetQuery(query);
            if (dr.Read())
            {
                db.Close();
                return true;
            }
            db.Close();
            return false;
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
