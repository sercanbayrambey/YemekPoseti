namespace YemekPoşeti
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
			this.TabMain = new MetroFramework.Controls.MetroTabControl();
			this.TabPageHome = new MetroFramework.Controls.MetroTabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.lblRestList = new System.Windows.Forms.Label();
			this.panelRestourant = new MetroFramework.Controls.MetroPanel();
			this.TabPageProfile = new MetroFramework.Controls.MetroTabPage();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblRegister = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.pBoxProfilePic = new System.Windows.Forms.PictureBox();
			this.TabPageOrder = new MetroFramework.Controls.MetroTabPage();
			this.lblSumPrice = new System.Windows.Forms.Label();
			this.lblSum = new System.Windows.Forms.Label();
			this.lblBasketDesc = new System.Windows.Forms.Label();
			this.lblBasket = new System.Windows.Forms.Label();
			this.panelBasket = new MetroFramework.Controls.MetroPanel();
			this.lblOrderTopDesc = new System.Windows.Forms.Label();
			this.lblOrderRestName = new System.Windows.Forms.Label();
			this.panelFoodMenu = new MetroFramework.Controls.MetroPanel();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.TabMain.SuspendLayout();
			this.TabPageHome.SuspendLayout();
			this.TabPageProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).BeginInit();
			this.TabPageOrder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// TabMain
			// 
			this.TabMain.Controls.Add(this.TabPageHome);
			this.TabMain.Controls.Add(this.TabPageProfile);
			this.TabMain.Controls.Add(this.TabPageOrder);
			this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMain.Location = new System.Drawing.Point(20, 60);
			this.TabMain.Name = "TabMain";
			this.TabMain.SelectedIndex = 2;
			this.TabMain.Size = new System.Drawing.Size(1211, 786);
			this.TabMain.Style = MetroFramework.MetroColorStyle.Purple;
			this.TabMain.TabIndex = 0;
			this.TabMain.UseSelectable = true;
			// 
			// TabPageHome
			// 
			this.TabPageHome.BackColor = System.Drawing.Color.White;
			this.TabPageHome.Controls.Add(this.label1);
			this.TabPageHome.Controls.Add(this.lblRestList);
			this.TabPageHome.Controls.Add(this.panelRestourant);
			this.TabPageHome.HorizontalScrollbarBarColor = true;
			this.TabPageHome.HorizontalScrollbarHighlightOnWheel = false;
			this.TabPageHome.HorizontalScrollbarSize = 10;
			this.TabPageHome.Location = new System.Drawing.Point(4, 38);
			this.TabPageHome.Name = "TabPageHome";
			this.TabPageHome.Size = new System.Drawing.Size(1203, 744);
			this.TabPageHome.Style = MetroFramework.MetroColorStyle.Purple;
			this.TabPageHome.TabIndex = 0;
			this.TabPageHome.Text = "Anasayfa";
			this.TabPageHome.UseCustomBackColor = true;
			this.TabPageHome.VerticalScrollbarBarColor = true;
			this.TabPageHome.VerticalScrollbarHighlightOnWheel = false;
			this.TabPageHome.VerticalScrollbarSize = 10;
			this.TabPageHome.Click += new System.EventHandler(this.TabPageHome_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(5, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Sipariş vermek istediğiniz restoranı seçiniz...";
			// 
			// lblRestList
			// 
			this.lblRestList.AutoSize = true;
			this.lblRestList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblRestList.Location = new System.Drawing.Point(4, 17);
			this.lblRestList.Name = "lblRestList";
			this.lblRestList.Size = new System.Drawing.Size(146, 23);
			this.lblRestList.TabIndex = 3;
			this.lblRestList.Text = "Restoran Listesi";
			// 
			// panelRestourant
			// 
			this.panelRestourant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelRestourant.AutoScroll = true;
			this.panelRestourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRestourant.HorizontalScrollbar = true;
			this.panelRestourant.HorizontalScrollbarBarColor = false;
			this.panelRestourant.HorizontalScrollbarHighlightOnWheel = false;
			this.panelRestourant.HorizontalScrollbarSize = 10;
			this.panelRestourant.Location = new System.Drawing.Point(7, 63);
			this.panelRestourant.Name = "panelRestourant";
			this.panelRestourant.Size = new System.Drawing.Size(680, 675);
			this.panelRestourant.TabIndex = 2;
			this.panelRestourant.VerticalScrollbar = true;
			this.panelRestourant.VerticalScrollbarBarColor = false;
			this.panelRestourant.VerticalScrollbarHighlightOnWheel = false;
			this.panelRestourant.VerticalScrollbarSize = 10;
			// 
			// TabPageProfile
			// 
			this.TabPageProfile.Controls.Add(this.lblDate);
			this.TabPageProfile.Controls.Add(this.lblRegister);
			this.TabPageProfile.Controls.Add(this.lblCity);
			this.TabPageProfile.Controls.Add(this.lblUsername);
			this.TabPageProfile.Controls.Add(this.pBoxProfilePic);
			this.TabPageProfile.HorizontalScrollbarBarColor = true;
			this.TabPageProfile.HorizontalScrollbarHighlightOnWheel = false;
			this.TabPageProfile.HorizontalScrollbarSize = 10;
			this.TabPageProfile.Location = new System.Drawing.Point(4, 38);
			this.TabPageProfile.Name = "TabPageProfile";
			this.TabPageProfile.Size = new System.Drawing.Size(1203, 744);
			this.TabPageProfile.TabIndex = 1;
			this.TabPageProfile.Text = "Profilim";
			this.TabPageProfile.VerticalScrollbarBarColor = true;
			this.TabPageProfile.VerticalScrollbarHighlightOnWheel = false;
			this.TabPageProfile.VerticalScrollbarSize = 10;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.BackColor = System.Drawing.Color.Transparent;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(114, 206);
			this.lblDate.Margin = new System.Windows.Forms.Padding(0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(89, 20);
			this.lblDate.TabIndex = 6;
			this.lblDate.Text = "00/00/0000";
			// 
			// lblRegister
			// 
			this.lblRegister.AutoSize = true;
			this.lblRegister.BackColor = System.Drawing.Color.Transparent;
			this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegister.Location = new System.Drawing.Point(0, 206);
			this.lblRegister.Margin = new System.Windows.Forms.Padding(0);
			this.lblRegister.Name = "lblRegister";
			this.lblRegister.Size = new System.Drawing.Size(107, 20);
			this.lblRegister.TabIndex = 5;
			this.lblRegister.Text = "Kayıt Tarihi: ";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.BackColor = System.Drawing.Color.Transparent;
			this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(212, 42);
			this.lblCity.Margin = new System.Windows.Forms.Padding(0);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(46, 20);
			this.lblCity.TabIndex = 4;
			this.lblCity.Text = "Şehir";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(209, 3);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(197, 39);
			this.lblUsername.TabIndex = 3;
			this.lblUsername.Text = "KullaniciAdi";
			// 
			// pBoxProfilePic
			// 
			this.pBoxProfilePic.Location = new System.Drawing.Point(3, 3);
			this.pBoxProfilePic.Name = "pBoxProfilePic";
			this.pBoxProfilePic.Size = new System.Drawing.Size(200, 200);
			this.pBoxProfilePic.TabIndex = 2;
			this.pBoxProfilePic.TabStop = false;
			// 
			// TabPageOrder
			// 
			this.TabPageOrder.Controls.Add(this.lblSumPrice);
			this.TabPageOrder.Controls.Add(this.lblSum);
			this.TabPageOrder.Controls.Add(this.lblBasketDesc);
			this.TabPageOrder.Controls.Add(this.lblBasket);
			this.TabPageOrder.Controls.Add(this.panelBasket);
			this.TabPageOrder.Controls.Add(this.lblOrderTopDesc);
			this.TabPageOrder.Controls.Add(this.lblOrderRestName);
			this.TabPageOrder.Controls.Add(this.panelFoodMenu);
			this.TabPageOrder.HorizontalScrollbarBarColor = true;
			this.TabPageOrder.HorizontalScrollbarHighlightOnWheel = false;
			this.TabPageOrder.HorizontalScrollbarSize = 8;
			this.TabPageOrder.Location = new System.Drawing.Point(4, 38);
			this.TabPageOrder.Margin = new System.Windows.Forms.Padding(2);
			this.TabPageOrder.Name = "TabPageOrder";
			this.TabPageOrder.Size = new System.Drawing.Size(1203, 744);
			this.TabPageOrder.TabIndex = 2;
			this.TabPageOrder.Text = "Sipariş";
			this.TabPageOrder.VerticalScrollbarBarColor = true;
			this.TabPageOrder.VerticalScrollbarHighlightOnWheel = false;
			this.TabPageOrder.VerticalScrollbarSize = 8;
			// 
			// lblSumPrice
			// 
			this.lblSumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSumPrice.AutoSize = true;
			this.lblSumPrice.BackColor = System.Drawing.Color.Transparent;
			this.lblSumPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
			this.lblSumPrice.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblSumPrice.Location = new System.Drawing.Point(820, 654);
			this.lblSumPrice.Name = "lblSumPrice";
			this.lblSumPrice.Size = new System.Drawing.Size(66, 22);
			this.lblSumPrice.TabIndex = 12;
			this.lblSumPrice.Text = "0,00 TL";
			// 
			// lblSum
			// 
			this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSum.AutoSize = true;
			this.lblSum.BackColor = System.Drawing.Color.Transparent;
			this.lblSum.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
			this.lblSum.ForeColor = System.Drawing.Color.DarkViolet;
			this.lblSum.Location = new System.Drawing.Point(741, 654);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(80, 22);
			this.lblSum.TabIndex = 11;
			this.lblSum.Text = "Toplam:";
			// 
			// lblBasketDesc
			// 
			this.lblBasketDesc.AutoSize = true;
			this.lblBasketDesc.BackColor = System.Drawing.Color.Transparent;
			this.lblBasketDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
			this.lblBasketDesc.Location = new System.Drawing.Point(742, 31);
			this.lblBasketDesc.Name = "lblBasketDesc";
			this.lblBasketDesc.Size = new System.Drawing.Size(92, 17);
			this.lblBasketDesc.TabIndex = 10;
			this.lblBasketDesc.Text = "Afiyet olsun..";
			// 
			// lblBasket
			// 
			this.lblBasket.AutoSize = true;
			this.lblBasket.BackColor = System.Drawing.Color.Transparent;
			this.lblBasket.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblBasket.Location = new System.Drawing.Point(741, 8);
			this.lblBasket.Name = "lblBasket";
			this.lblBasket.Size = new System.Drawing.Size(82, 23);
			this.lblBasket.TabIndex = 9;
			this.lblBasket.Text = "Poşetim";
			// 
			// panelBasket
			// 
			this.panelBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelBasket.AutoScroll = true;
			this.panelBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBasket.HorizontalScrollbar = true;
			this.panelBasket.HorizontalScrollbarBarColor = true;
			this.panelBasket.HorizontalScrollbarHighlightOnWheel = false;
			this.panelBasket.HorizontalScrollbarSize = 10;
			this.panelBasket.Location = new System.Drawing.Point(745, 54);
			this.panelBasket.Name = "panelBasket";
			this.panelBasket.Size = new System.Drawing.Size(462, 584);
			this.panelBasket.TabIndex = 8;
			this.panelBasket.VerticalScrollbar = true;
			this.panelBasket.VerticalScrollbarBarColor = true;
			this.panelBasket.VerticalScrollbarHighlightOnWheel = false;
			this.panelBasket.VerticalScrollbarSize = 10;
			this.panelBasket.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBasket_Paint);
			// 
			// lblOrderTopDesc
			// 
			this.lblOrderTopDesc.AutoSize = true;
			this.lblOrderTopDesc.BackColor = System.Drawing.Color.Transparent;
			this.lblOrderTopDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
			this.lblOrderTopDesc.Location = new System.Drawing.Point(4, 31);
			this.lblOrderTopDesc.Name = "lblOrderTopDesc";
			this.lblOrderTopDesc.Size = new System.Drawing.Size(146, 17);
			this.lblOrderTopDesc.TabIndex = 7;
			this.lblOrderTopDesc.Text = "Siparişlerinizi seçiniz..";
			// 
			// lblOrderRestName
			// 
			this.lblOrderRestName.AutoSize = true;
			this.lblOrderRestName.BackColor = System.Drawing.Color.Transparent;
			this.lblOrderRestName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblOrderRestName.Location = new System.Drawing.Point(3, 8);
			this.lblOrderRestName.Name = "lblOrderRestName";
			this.lblOrderRestName.Size = new System.Drawing.Size(126, 23);
			this.lblOrderRestName.TabIndex = 6;
			this.lblOrderRestName.Text = "Restoran Adı";
			// 
			// panelFoodMenu
			// 
			this.panelFoodMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelFoodMenu.AutoScroll = true;
			this.panelFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFoodMenu.HorizontalScrollbar = true;
			this.panelFoodMenu.HorizontalScrollbarBarColor = false;
			this.panelFoodMenu.HorizontalScrollbarHighlightOnWheel = false;
			this.panelFoodMenu.HorizontalScrollbarSize = 10;
			this.panelFoodMenu.Location = new System.Drawing.Point(6, 54);
			this.panelFoodMenu.Name = "panelFoodMenu";
			this.panelFoodMenu.Size = new System.Drawing.Size(680, 675);
			this.panelFoodMenu.TabIndex = 5;
			this.panelFoodMenu.VerticalScrollbar = true;
			this.panelFoodMenu.VerticalScrollbarBarColor = false;
			this.panelFoodMenu.VerticalScrollbarHighlightOnWheel = false;
			this.panelFoodMenu.VerticalScrollbarSize = 10;
			this.panelFoodMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFoodMenu_Paint);
			// 
			// pboxLogo
			// 
			this.pboxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
			this.pboxLogo.Location = new System.Drawing.Point(1031, 36);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(200, 50);
			this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxLogo.TabIndex = 3;
			this.pboxLogo.TabStop = false;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1251, 866);
			this.Controls.Add(this.pboxLogo);
			this.Controls.Add(this.TabMain);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MainScreen";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TabMain.ResumeLayout(false);
			this.TabPageHome.ResumeLayout(false);
			this.TabPageHome.PerformLayout();
			this.TabPageProfile.ResumeLayout(false);
			this.TabPageProfile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).EndInit();
			this.TabPageOrder.ResumeLayout(false);
			this.TabPageOrder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroTabControl TabMain;
		private MetroFramework.Controls.MetroTabPage TabPageHome;
		private MetroFramework.Controls.MetroTabPage TabPageProfile;
		private System.Windows.Forms.PictureBox pboxLogo;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblRegister;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pBoxProfilePic;
		private MetroFramework.Controls.MetroPanel panelRestourant;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblRestList;
        private MetroFramework.Controls.MetroTabPage TabPageOrder;
        private System.Windows.Forms.Label lblOrderTopDesc;
        private System.Windows.Forms.Label lblOrderRestName;
        private MetroFramework.Controls.MetroPanel panelFoodMenu;
		public MetroFramework.Controls.MetroPanel panelBasket;
		private System.Windows.Forms.Label lblBasketDesc;
		private System.Windows.Forms.Label lblBasket;
		private System.Windows.Forms.Label lblSum;
		public System.Windows.Forms.Label lblSumPrice;
	}
}

