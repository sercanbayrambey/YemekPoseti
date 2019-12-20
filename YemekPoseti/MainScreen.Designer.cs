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
            this.lblCompleteOrderDesc = new System.Windows.Forms.Label();
            this.lblCompleteOrder = new System.Windows.Forms.Label();
            this.panelCompleteOrder = new MetroFramework.Controls.MetroPanel();
            this.tboxAdress = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxUrunler = new System.Windows.Forms.ListBox();
            this.btnOrder = new MetroFramework.Controls.MetroButton();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblFinalSumPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblSumDiscount = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblBasketDesc = new System.Windows.Forms.Label();
            this.lblBasket = new System.Windows.Forms.Label();
            this.panelBasket = new MetroFramework.Controls.MetroPanel();
            this.lblOrderTopDesc = new System.Windows.Forms.Label();
            this.lblOrderRestName = new System.Windows.Forms.Label();
            this.panelFoodMenu = new MetroFramework.Controls.MetroPanel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.lblUserOrdersDesc = new System.Windows.Forms.Label();
            this.lblUserOrders = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TabMain.SuspendLayout();
            this.TabPageHome.SuspendLayout();
            this.TabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).BeginInit();
            this.TabPageOrder.SuspendLayout();
            this.panelCompleteOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabPageHome);
            this.TabMain.Controls.Add(this.TabPageProfile);
            this.TabMain.Controls.Add(this.TabPageOrder);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(27, 74);
            this.TabMain.Margin = new System.Windows.Forms.Padding(4);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(1866, 967);
            this.TabMain.Style = MetroFramework.MetroColorStyle.Purple;
            this.TabMain.TabIndex = 0;
            this.TabMain.UseSelectable = true;
            // 
            // TabPageHome
            // 
            this.TabPageHome.BackColor = System.Drawing.Color.White;
            this.TabPageHome.Controls.Add(this.metroPanel1);
            this.TabPageHome.Controls.Add(this.lblUserOrdersDesc);
            this.TabPageHome.Controls.Add(this.lblUserOrders);
            this.TabPageHome.Controls.Add(this.label1);
            this.TabPageHome.Controls.Add(this.lblRestList);
            this.TabPageHome.Controls.Add(this.panelRestourant);
            this.TabPageHome.HorizontalScrollbarBarColor = true;
            this.TabPageHome.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageHome.HorizontalScrollbarSize = 12;
            this.TabPageHome.Location = new System.Drawing.Point(4, 38);
            this.TabPageHome.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageHome.Name = "TabPageHome";
            this.TabPageHome.Size = new System.Drawing.Size(1858, 925);
            this.TabPageHome.Style = MetroFramework.MetroColorStyle.Purple;
            this.TabPageHome.TabIndex = 0;
            this.TabPageHome.Text = "Anasayfa";
            this.TabPageHome.UseCustomBackColor = true;
            this.TabPageHome.VerticalScrollbarBarColor = true;
            this.TabPageHome.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageHome.VerticalScrollbarSize = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sipariş vermek istediğiniz restoranı seçiniz...";
            // 
            // lblRestList
            // 
            this.lblRestList.AutoSize = true;
            this.lblRestList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRestList.Location = new System.Drawing.Point(5, 21);
            this.lblRestList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestList.Name = "lblRestList";
            this.lblRestList.Size = new System.Drawing.Size(186, 28);
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
            this.panelRestourant.HorizontalScrollbarSize = 12;
            this.panelRestourant.Location = new System.Drawing.Point(9, 78);
            this.panelRestourant.Margin = new System.Windows.Forms.Padding(4);
            this.panelRestourant.Name = "panelRestourant";
            this.panelRestourant.Size = new System.Drawing.Size(906, 830);
            this.panelRestourant.TabIndex = 2;
            this.panelRestourant.VerticalScrollbar = true;
            this.panelRestourant.VerticalScrollbarBarColor = false;
            this.panelRestourant.VerticalScrollbarHighlightOnWheel = false;
            this.panelRestourant.VerticalScrollbarSize = 13;
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
            this.TabPageProfile.HorizontalScrollbarSize = 12;
            this.TabPageProfile.Location = new System.Drawing.Point(4, 38);
            this.TabPageProfile.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageProfile.Name = "TabPageProfile";
            this.TabPageProfile.Size = new System.Drawing.Size(1858, 925);
            this.TabPageProfile.TabIndex = 1;
            this.TabPageProfile.Text = "Profilim";
            this.TabPageProfile.VerticalScrollbarBarColor = true;
            this.TabPageProfile.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageProfile.VerticalScrollbarSize = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(152, 254);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(112, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "00/00/0000";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(0, 254);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(135, 25);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Kayıt Tarihi: ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(283, 52);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 25);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Şehir";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(279, 4);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(249, 52);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "KullaniciAdi";
            // 
            // pBoxProfilePic
            // 
            this.pBoxProfilePic.Location = new System.Drawing.Point(4, 4);
            this.pBoxProfilePic.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxProfilePic.Name = "pBoxProfilePic";
            this.pBoxProfilePic.Size = new System.Drawing.Size(267, 246);
            this.pBoxProfilePic.TabIndex = 2;
            this.pBoxProfilePic.TabStop = false;
            // 
            // TabPageOrder
            // 
            this.TabPageOrder.Controls.Add(this.lblCompleteOrderDesc);
            this.TabPageOrder.Controls.Add(this.lblCompleteOrder);
            this.TabPageOrder.Controls.Add(this.panelCompleteOrder);
            this.TabPageOrder.Controls.Add(this.lblMin);
            this.TabPageOrder.Controls.Add(this.lblFinalSumPrice);
            this.TabPageOrder.Controls.Add(this.lblFinalPrice);
            this.TabPageOrder.Controls.Add(this.lblSumDiscount);
            this.TabPageOrder.Controls.Add(this.lblSumPrice);
            this.TabPageOrder.Controls.Add(this.lblDiscount);
            this.TabPageOrder.Controls.Add(this.lblSum);
            this.TabPageOrder.Controls.Add(this.lblBasketDesc);
            this.TabPageOrder.Controls.Add(this.lblBasket);
            this.TabPageOrder.Controls.Add(this.panelBasket);
            this.TabPageOrder.Controls.Add(this.lblOrderTopDesc);
            this.TabPageOrder.Controls.Add(this.lblOrderRestName);
            this.TabPageOrder.Controls.Add(this.panelFoodMenu);
            this.TabPageOrder.HorizontalScrollbarBarColor = true;
            this.TabPageOrder.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageOrder.HorizontalScrollbarSize = 10;
            this.TabPageOrder.Location = new System.Drawing.Point(4, 38);
            this.TabPageOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPageOrder.Name = "TabPageOrder";
            this.TabPageOrder.Size = new System.Drawing.Size(1858, 925);
            this.TabPageOrder.TabIndex = 2;
            this.TabPageOrder.Text = "Sipariş";
            this.TabPageOrder.VerticalScrollbarBarColor = true;
            this.TabPageOrder.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageOrder.VerticalScrollbarSize = 11;
            // 
            // lblCompleteOrderDesc
            // 
            this.lblCompleteOrderDesc.AutoSize = true;
            this.lblCompleteOrderDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteOrderDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblCompleteOrderDesc.Location = new System.Drawing.Point(1389, 38);
            this.lblCompleteOrderDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleteOrderDesc.Name = "lblCompleteOrderDesc";
            this.lblCompleteOrderDesc.Size = new System.Drawing.Size(120, 21);
            this.lblCompleteOrderDesc.TabIndex = 19;
            this.lblCompleteOrderDesc.Text = "Afiyet olsun...";
            // 
            // lblCompleteOrder
            // 
            this.lblCompleteOrder.AutoSize = true;
            this.lblCompleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCompleteOrder.Location = new System.Drawing.Point(1388, 10);
            this.lblCompleteOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleteOrder.Name = "lblCompleteOrder";
            this.lblCompleteOrder.Size = new System.Drawing.Size(210, 28);
            this.lblCompleteOrder.TabIndex = 18;
            this.lblCompleteOrder.Text = "Siparişi Tamamla";
            // 
            // panelCompleteOrder
            // 
            this.panelCompleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompleteOrder.AutoScroll = true;
            this.panelCompleteOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompleteOrder.Controls.Add(this.tboxAdress);
            this.panelCompleteOrder.Controls.Add(this.label2);
            this.panelCompleteOrder.Controls.Add(this.lboxUrunler);
            this.panelCompleteOrder.Controls.Add(this.btnOrder);
            this.panelCompleteOrder.HorizontalScrollbar = true;
            this.panelCompleteOrder.HorizontalScrollbarBarColor = false;
            this.panelCompleteOrder.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCompleteOrder.HorizontalScrollbarSize = 12;
            this.panelCompleteOrder.Location = new System.Drawing.Point(1389, 66);
            this.panelCompleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelCompleteOrder.Name = "panelCompleteOrder";
            this.panelCompleteOrder.Size = new System.Drawing.Size(468, 830);
            this.panelCompleteOrder.TabIndex = 17;
            this.panelCompleteOrder.VerticalScrollbar = true;
            this.panelCompleteOrder.VerticalScrollbarBarColor = false;
            this.panelCompleteOrder.VerticalScrollbarHighlightOnWheel = false;
            this.panelCompleteOrder.VerticalScrollbarSize = 13;
            // 
            // tboxAdress
            // 
            // 
            // 
            // 
            this.tboxAdress.CustomButton.Image = null;
            this.tboxAdress.CustomButton.Location = new System.Drawing.Point(336, 2);
            this.tboxAdress.CustomButton.Name = "";
            this.tboxAdress.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.tboxAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxAdress.CustomButton.TabIndex = 1;
            this.tboxAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxAdress.CustomButton.UseSelectable = true;
            this.tboxAdress.CustomButton.Visible = false;
            this.tboxAdress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tboxAdress.Lines = new string[] {
        "Adresinizi giriniz..."};
            this.tboxAdress.Location = new System.Drawing.Point(3, 236);
            this.tboxAdress.MaxLength = 32767;
            this.tboxAdress.Multiline = true;
            this.tboxAdress.Name = "tboxAdress";
            this.tboxAdress.PasswordChar = '\0';
            this.tboxAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxAdress.SelectedText = "";
            this.tboxAdress.SelectionLength = 0;
            this.tboxAdress.SelectionStart = 0;
            this.tboxAdress.ShortcutsEnabled = true;
            this.tboxAdress.Size = new System.Drawing.Size(460, 126);
            this.tboxAdress.TabIndex = 20;
            this.tboxAdress.Text = "Adresinizi giriniz...";
            this.tboxAdress.UseSelectable = true;
            this.tboxAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tboxAdress.Enter += new System.EventHandler(this.tboxAdress_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-1, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sipariş Adresiniz:";
            // 
            // lboxUrunler
            // 
            this.lboxUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboxUrunler.FormattingEnabled = true;
            this.lboxUrunler.ItemHeight = 16;
            this.lboxUrunler.Location = new System.Drawing.Point(0, 0);
            this.lboxUrunler.Name = "lboxUrunler";
            this.lboxUrunler.Size = new System.Drawing.Size(466, 180);
            this.lboxUrunler.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOrder.Location = new System.Drawing.Point(103, 778);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(288, 46);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Siparişi Tamamla";
            this.btnOrder.UseCustomBackColor = true;
            this.btnOrder.UseCustomForeColor = true;
            this.btnOrder.UseSelectable = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(1202, 45);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(179, 17);
            this.lblMin.TabIndex = 16;
            this.lblMin.Text = "Min. Sipariş Tutarı: 0,00 TL";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalSumPrice
            // 
            this.lblFinalSumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinalSumPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalSumPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFinalSumPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFinalSumPrice.Location = new System.Drawing.Point(1031, 869);
            this.lblFinalSumPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalSumPrice.Name = "lblFinalSumPrice";
            this.lblFinalSumPrice.Size = new System.Drawing.Size(350, 26);
            this.lblFinalSumPrice.TabIndex = 15;
            this.lblFinalSumPrice.Text = "0,00 TL";
            this.lblFinalSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFinalPrice.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblFinalPrice.Location = new System.Drawing.Point(761, 869);
            this.lblFinalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(190, 26);
            this.lblFinalPrice.TabIndex = 14;
            this.lblFinalPrice.Text = "Ödenecek Tutar:";
            // 
            // lblSumDiscount
            // 
            this.lblSumDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblSumDiscount.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblSumDiscount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSumDiscount.Location = new System.Drawing.Point(1031, 837);
            this.lblSumDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumDiscount.Name = "lblSumDiscount";
            this.lblSumDiscount.Size = new System.Drawing.Size(350, 26);
            this.lblSumDiscount.TabIndex = 12;
            this.lblSumDiscount.Text = "0,00 TL";
            this.lblSumDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSumPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblSumPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSumPrice.Location = new System.Drawing.Point(1031, 805);
            this.lblSumPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(350, 26);
            this.lblSumPrice.TabIndex = 12;
            this.lblSumPrice.Text = "0,00 TL";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblDiscount.Location = new System.Drawing.Point(761, 837);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(257, 26);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Sepete Özel İndiriminiz:";
            // 
            // lblSum
            // 
            this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblSum.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSum.Location = new System.Drawing.Point(761, 805);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(97, 26);
            this.lblSum.TabIndex = 11;
            this.lblSum.Text = "Toplam:";
            // 
            // lblBasketDesc
            // 
            this.lblBasketDesc.AutoSize = true;
            this.lblBasketDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblBasketDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblBasketDesc.Location = new System.Drawing.Point(762, 38);
            this.lblBasketDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasketDesc.Name = "lblBasketDesc";
            this.lblBasketDesc.Size = new System.Drawing.Size(191, 21);
            this.lblBasketDesc.TabIndex = 10;
            this.lblBasketDesc.Text = "Poşetinizdeki ürünler...";
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.BackColor = System.Drawing.Color.Transparent;
            this.lblBasket.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBasket.Location = new System.Drawing.Point(761, 10);
            this.lblBasket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(102, 28);
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
            this.panelBasket.HorizontalScrollbarSize = 12;
            this.panelBasket.Location = new System.Drawing.Point(766, 66);
            this.panelBasket.Margin = new System.Windows.Forms.Padding(4);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(615, 718);
            this.panelBasket.TabIndex = 8;
            this.panelBasket.VerticalScrollbar = true;
            this.panelBasket.VerticalScrollbarBarColor = true;
            this.panelBasket.VerticalScrollbarHighlightOnWheel = false;
            this.panelBasket.VerticalScrollbarSize = 13;
            // 
            // lblOrderTopDesc
            // 
            this.lblOrderTopDesc.AutoSize = true;
            this.lblOrderTopDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTopDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblOrderTopDesc.Location = new System.Drawing.Point(5, 38);
            this.lblOrderTopDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTopDesc.Name = "lblOrderTopDesc";
            this.lblOrderTopDesc.Size = new System.Drawing.Size(185, 21);
            this.lblOrderTopDesc.TabIndex = 7;
            this.lblOrderTopDesc.Text = "Siparişlerinizi seçiniz...";
            // 
            // lblOrderRestName
            // 
            this.lblOrderRestName.AutoSize = true;
            this.lblOrderRestName.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderRestName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOrderRestName.Location = new System.Drawing.Point(4, 10);
            this.lblOrderRestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderRestName.Name = "lblOrderRestName";
            this.lblOrderRestName.Size = new System.Drawing.Size(159, 28);
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
            this.panelFoodMenu.HorizontalScrollbarSize = 12;
            this.panelFoodMenu.Location = new System.Drawing.Point(8, 66);
            this.panelFoodMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelFoodMenu.Name = "panelFoodMenu";
            this.panelFoodMenu.Size = new System.Drawing.Size(750, 830);
            this.panelFoodMenu.TabIndex = 5;
            this.panelFoodMenu.VerticalScrollbar = true;
            this.panelFoodMenu.VerticalScrollbarBarColor = false;
            this.panelFoodMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelFoodMenu.VerticalScrollbarSize = 13;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(1626, 42);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(267, 62);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 3;
            this.pboxLogo.TabStop = false;
            // 
            // lblUserOrdersDesc
            // 
            this.lblUserOrdersDesc.AutoSize = true;
            this.lblUserOrdersDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblUserOrdersDesc.Location = new System.Drawing.Point(926, 49);
            this.lblUserOrdersDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOrdersDesc.Name = "lblUserOrdersDesc";
            this.lblUserOrdersDesc.Size = new System.Drawing.Size(418, 21);
            this.lblUserOrdersDesc.TabIndex = 6;
            this.lblUserOrdersDesc.Text = "Burada aktif ve geçmiş siparişlerinizi görebilirsiniz.";
            // 
            // lblUserOrders
            // 
            this.lblUserOrders.AutoSize = true;
            this.lblUserOrders.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserOrders.Location = new System.Drawing.Point(924, 21);
            this.lblUserOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOrders.Name = "lblUserOrders";
            this.lblUserOrders.Size = new System.Drawing.Size(145, 28);
            this.lblUserOrders.TabIndex = 5;
            this.lblUserOrders.Text = "Siparişlerim";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(930, 78);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(572, 830);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1066);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.TabMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "YemekPoşeti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.TabMain.ResumeLayout(false);
            this.TabPageHome.ResumeLayout(false);
            this.TabPageHome.PerformLayout();
            this.TabPageProfile.ResumeLayout(false);
            this.TabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).EndInit();
            this.TabPageOrder.ResumeLayout(false);
            this.TabPageOrder.PerformLayout();
            this.panelCompleteOrder.ResumeLayout(false);
            this.panelCompleteOrder.PerformLayout();
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
		private MetroFramework.Controls.MetroButton btnOrder;
		public System.Windows.Forms.Label lblFinalSumPrice;
		private System.Windows.Forms.Label lblFinalPrice;
		public System.Windows.Forms.Label lblSumDiscount;
		private System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblCompleteOrderDesc;
        private System.Windows.Forms.Label lblCompleteOrder;
        public MetroFramework.Controls.MetroPanel panelCompleteOrder;
        public System.Windows.Forms.ListBox lboxUrunler;
        private MetroFramework.Controls.MetroTextBox tboxAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserOrdersDesc;
        private System.Windows.Forms.Label lblUserOrders;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

