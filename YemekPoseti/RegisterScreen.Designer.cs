namespace YemekPoşeti
{
	partial class RegisterScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
			this.btnRegister = new MetroFramework.Controls.MetroButton();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.Violet;
			this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnRegister.Location = new System.Drawing.Point(122, 400);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(120, 45);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Kayıt Ol!";
			this.btnRegister.UseCustomBackColor = true;
			this.btnRegister.UseSelectable = true;
			// 
			// txtUserName
			// 
			// 
			// 
			// 
			this.txtUserName.CustomButton.Image = null;
			this.txtUserName.CustomButton.Location = new System.Drawing.Point(166, 2);
			this.txtUserName.CustomButton.Name = "";
			this.txtUserName.CustomButton.Size = new System.Drawing.Size(19, 20);
			this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserName.CustomButton.TabIndex = 1;
			this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserName.CustomButton.UseSelectable = true;
			this.txtUserName.CustomButton.Visible = false;
			this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtUserName.ForeColor = System.Drawing.Color.DarkGray;
			this.txtUserName.Lines = new string[] {
        "Kullanıcı adınız.."};
			this.txtUserName.Location = new System.Drawing.Point(57, 188);
			this.txtUserName.MaxLength = 32767;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.PasswordChar = '\0';
			this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserName.SelectedText = "";
			this.txtUserName.SelectionLength = 0;
			this.txtUserName.SelectionStart = 0;
			this.txtUserName.ShortcutsEnabled = true;
			this.txtUserName.Size = new System.Drawing.Size(250, 30);
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
			this.txtPass.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.txtPass.CustomButton.Name = "";
			this.txtPass.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.CustomButton.TabIndex = 1;
			this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPass.CustomButton.UseSelectable = true;
			this.txtPass.CustomButton.Visible = false;
			this.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
			this.txtPass.Lines = new string[] {
        "Ad Soyad"};
			this.txtPass.Location = new System.Drawing.Point(57, 133);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(250, 30);
			this.txtPass.TabIndex = 2;
			this.txtPass.Text = "Ad Soyad";
			this.txtPass.UseCustomForeColor = true;
			this.txtPass.UseSelectable = true;
			this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			// 
			// pboxLogo
			// 
			this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
			this.pboxLogo.Location = new System.Drawing.Point(23, 23);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(200, 48);
			this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxLogo.TabIndex = 2;
			this.pboxLogo.TabStop = false;
			// 
			// metroTextBox1
			// 
			// 
			// 
			// 
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBox1.ForeColor = System.Drawing.Color.DarkGray;
			this.metroTextBox1.Lines = new string[] {
        "Şifre"};
			this.metroTextBox1.Location = new System.Drawing.Point(57, 298);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new System.Drawing.Size(250, 30);
			this.metroTextBox1.TabIndex = 1;
			this.metroTextBox1.Text = "Şifre";
			this.metroTextBox1.UseCustomForeColor = true;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox1.Enter += new System.EventHandler(this.txtUserName_Enter);
			// 
			// metroTextBox2
			// 
			// 
			// 
			// 
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBox2.ForeColor = System.Drawing.Color.DarkGray;
			this.metroTextBox2.Lines = new string[] {
        "E-Mail"};
			this.metroTextBox2.Location = new System.Drawing.Point(57, 243);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new System.Drawing.Size(250, 30);
			this.metroTextBox2.TabIndex = 1;
			this.metroTextBox2.Text = "E-Mail";
			this.metroTextBox2.UseCustomForeColor = true;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox2.Enter += new System.EventHandler(this.txtUserName_Enter);
			// 
			// RegisterScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(365, 580);
			this.Controls.Add(this.pboxLogo);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.metroTextBox2);
			this.Controls.Add(this.metroTextBox1);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnRegister);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "RegisterScreen";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnRegister;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private System.Windows.Forms.PictureBox pboxLogo;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroTextBox metroTextBox2;
	}
}

