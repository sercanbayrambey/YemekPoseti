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
	public partial class RegisterScreen : MetroFramework.Forms.MetroForm
	{
		private DB db = new DB();
		private User LoggedUser;
		public RegisterScreen()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			
		}

		


		private void metroLabel1_Click(object sender, EventArgs e)
		{

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

		private void txtEmail_Enter(object sender, EventArgs e)
		{
			string defaultText = "E-Mail";
			if (txtEmail.Text.Equals(defaultText))
			{
				txtEmail.Clear();
				txtEmail.ForeColor = Color.Black;
			}
		}

		private void txtPass_Enter(object sender, EventArgs e)
		{
			string defaultText = "Şifre";
			if (txtPass.Text.Equals(defaultText))
			{
				txtPass.Clear();
				txtPass.ForeColor = Color.Black;
				txtPass.PasswordChar = '*';
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			User user = new User();

			if(txtUserName.Text != string.Empty || txtPass.Text != string.Empty || txtEmail.Text != string.Empty)
			{
				if (user.Register(txtUserName.Text.ToLower(), txtPass.Text, txtEmail.Text))
				{
					MessageBox.Show("Kaydınız başarıyla tamamlandı.");
					this.Close();
				}
				else
					MessageBox.Show("Kayıt sırasında bir hata oluştu.");
			}
			else
			{
				MessageBox.Show("HER YERİ DOLDUR");
			}
			
		}

		private void lblBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
