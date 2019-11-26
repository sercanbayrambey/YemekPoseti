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
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Violet;
            this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRegister.Location = new System.Drawing.Point(75, 506);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 55);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Kayıt Ol!";
            this.btnRegister.UseCustomBackColor = true;
            this.btnRegister.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.OldLace;
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogin.Location = new System.Drawing.Point(248, 506);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 55);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap!";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.txtUserName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.Lines = new string[] {
        "Kullanıcı adınız.."};
            this.txtUserName.Location = new System.Drawing.Point(75, 352);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(333, 37);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Kullanıcı adınız..";
            this.txtUserName.UseCustomForeColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.txtPass.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Lines = new string[] {
        "Şifrenizi giriniz.."};
            this.txtPass.Location = new System.Drawing.Point(75, 416);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(333, 37);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Şifrenizi giriniz..";
            this.txtPass.UseCustomForeColor = true;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(109, 85);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(267, 246);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(75, 457);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Şifremi unuttum";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(487, 714);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginScreen";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "YemekPoşeti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnRegister;
		private MetroFramework.Controls.MetroButton btnLogin;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private System.Windows.Forms.PictureBox pboxLogo;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}

