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
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.TabPageProfile = new MetroFramework.Controls.MetroTabPage();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.pBoxProfilePic = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblRegister = new System.Windows.Forms.Label();
			this.TabMain.SuspendLayout();
			this.TabPageProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).BeginInit();
			this.SuspendLayout();
			// 
			// TabMain
			// 
			this.TabMain.Controls.Add(this.metroTabPage1);
			this.TabMain.Controls.Add(this.TabPageProfile);
			this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMain.Location = new System.Drawing.Point(20, 60);
			this.TabMain.Name = "TabMain";
			this.TabMain.SelectedIndex = 1;
			this.TabMain.Size = new System.Drawing.Size(1211, 786);
			this.TabMain.TabIndex = 0;
			this.TabMain.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1203, 744);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "metroTabPage1";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
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
			// pboxLogo
			// 
			this.pboxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
			this.pboxLogo.Location = new System.Drawing.Point(1031, 42);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(200, 50);
			this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxLogo.TabIndex = 3;
			this.pboxLogo.TabStop = false;
			// 
			// pBoxProfilePic
			// 
			this.pBoxProfilePic.Location = new System.Drawing.Point(3, 3);
			this.pBoxProfilePic.Name = "pBoxProfilePic";
			this.pBoxProfilePic.Size = new System.Drawing.Size(200, 200);
			this.pBoxProfilePic.TabIndex = 2;
			this.pBoxProfilePic.TabStop = false;
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
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TabMain.ResumeLayout(false);
			this.TabPageProfile.ResumeLayout(false);
			this.TabPageProfile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroTabControl TabMain;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage TabPageProfile;
		private System.Windows.Forms.PictureBox pboxLogo;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblRegister;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pBoxProfilePic;
	}
}

