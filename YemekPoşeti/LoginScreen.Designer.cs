namespace YemekPoşeti
{
	partial class LoginScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
			this.btnRegister = new MetroFramework.Controls.MetroButton();
			this.btnLogin = new MetroFramework.Controls.MetroButton();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(56, 411);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(120, 45);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Kayıt Ol!";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(186, 411);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(120, 45);
			this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Giriş Yap";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBox1.Location = new System.Drawing.Point(56, 286);
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.Size = new System.Drawing.Size(250, 30);
			this.metroTextBox1.TabIndex = 1;
			this.metroTextBox1.Text = "metroTextBox1";
			// 
			// metroTextBox2
			// 
			this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBox2.Location = new System.Drawing.Point(56, 338);
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.Size = new System.Drawing.Size(250, 30);
			this.metroTextBox2.TabIndex = 1;
			this.metroTextBox2.Text = "metroTextBox1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(82, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 541);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(102, 19);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Şifremi unuttum";
			// 
			// LoginScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(365, 580);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.metroTextBox2);
			this.Controls.Add(this.metroTextBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "LoginScreen";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnRegister;
		private MetroFramework.Controls.MetroButton btnLogin;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroTextBox metroTextBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}

