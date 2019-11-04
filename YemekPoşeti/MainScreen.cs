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
        public MainScreen()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.Red;
		}
	}
}
