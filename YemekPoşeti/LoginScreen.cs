using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			this.BackColor = Color.Red;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			MainScreen mainScreen = new MainScreen();
			this.Hide();
			mainScreen.ShowDialog();
			this.Close();
		}
	}
}
