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
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
		private User LoggedUser;

        public MainScreen(User user)
        {
			LoggedUser = user;
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "HOŞGELDİN, " + LoggedUser.UserName.ToUpper() + "!";
			LoadProfileData();
			AddTemplate(20);
			
		}

		private void LoadProfileData()
		{
			lblUsername.Text = LoggedUser.UserName.ToUpper();
			lblCity.Text = LoggedUser.Location;
			lblDate.Text = LoggedUser.RegisterDate.ToShortDateString();
		}

		private void TabPageHome_Click(object sender, EventArgs e)
		{

		}

		private void AddTemplate(int i)
		{

			for (int j = 0; j < i; j++)
			{
				ucRestList ucTemp = new ucRestList();
				if (j % 2 == 0)
					ucTemp.BackColor = Color.FromArgb(255, 245, 255);
				ucTemp.Dock = DockStyle.Top;
				ucTemp.lblRestDesc.Text += j.ToString();
				panelRestourant.Controls.Add(ucTemp);
				/*ucTemp.Location = new Point(ucTemp.Location.X + 50, ucTemp.Location.Y + (j * ucTemp.Height) + 300); */// TODO: buna bi bak la
			}
		}

	}
	
}
