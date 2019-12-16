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
		private User LoggedUser;
		public LoginScreen()
		{
			InitializeComponent();
		}
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.AcceptButton = btnLogin;
        }
		private void btnLogin_Click(object sender, EventArgs e)
		{
            txtPass.Enabled = false;
            txtUserName.Enabled = false;
            btnLogin.Enabled = false;
            btnRegister.Enabled = false;
            string username = txtUserName.Text;
            string pass = txtPass.Text;
			User user = new User();
            if (user.Login(username, pass))
            {
				LoggedUser = user;
				MainScreen mainScreen = new MainScreen(LoggedUser);
                this.Hide();
				mainScreen.Show();
            }
            else
            {
                txtPass.Enabled = true;
                txtUserName.Enabled = true;
                btnLogin.Enabled = true;
                btnRegister.Enabled = true; 
                txtPass.Clear();
                txtPass.Select();
				lblErrorMsg.Text = "Giriş bilgileri hatalı!";
            }
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
		private void btnRegister_Click(object sender, EventArgs e)
		{
			RegisterScreen regscreen = new RegisterScreen();
			this.Hide();
			regscreen.ShowDialog();
			this.BringToFront();
			this.Show();
		}

     
    }
}
