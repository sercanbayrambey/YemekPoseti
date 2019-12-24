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
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.panelPastOrders = new MetroFramework.Controls.MetroPanel();
            this.lblUserOrdersDesc = new System.Windows.Forms.Label();
            this.lblUserOrders = new System.Windows.Forms.Label();
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
            this.lblMinPriceWarn = new System.Windows.Forms.Label();
            this.tboxAdress = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxUrunler = new System.Windows.Forms.ListBox();
            this.btnOrder = new MetroFramework.Controls.MetroButton();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFinalSumPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblSumDiscount = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblBasketDesc = new System.Windows.Forms.Label();
            this.lblBasket = new System.Windows.Forms.Label();
            this.panelBasket = new MetroFramework.Controls.MetroPanel();
            this.lblOrderTopDesc = new System.Windows.Forms.Label();
            this.lblOrderRestName = new System.Windows.Forms.Label();
            this.panelFoodMenu = new MetroFramework.Controls.MetroPanel();
            this.TabPageRestManagement = new MetroFramework.Controls.MetroTabPage();
            this.PanelRMOrders = new MetroFramework.Controls.MetroPanel();
            this.lblRMShowOrdersDesc = new System.Windows.Forms.Label();
            this.lblRMShowOrders = new System.Windows.Forms.Label();
            this.btnRMRefresh = new MetroFramework.Controls.MetroButton();
            this.panelRMAddFood = new MetroFramework.Controls.MetroPanel();
            this.tboxRMFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.btnRMAddFood = new MetroFramework.Controls.MetroButton();
            this.tboxRMFoodName = new MetroFramework.Controls.MetroTextBox();
            this.tboxRMFoodDesc = new MetroFramework.Controls.MetroTextBox();
            this.lblRMFoodName = new System.Windows.Forms.Label();
            this.lblRMFoodPrice = new System.Windows.Forms.Label();
            this.lblRMFoodDesc = new System.Windows.Forms.Label();
            this.lblRMAddFoodDesc = new System.Windows.Forms.Label();
            this.lblRMAddFood = new System.Windows.Forms.Label();
            this.panelRMRestSettings = new MetroFramework.Controls.MetroPanel();
            this.tboxRMMinOrderPrice = new System.Windows.Forms.NumericUpDown();
            this.cboxRMCity = new MetroFramework.Controls.MetroComboBox();
            this.btnRMSaveRestInfo = new MetroFramework.Controls.MetroButton();
            this.tboxRMRestName = new MetroFramework.Controls.MetroTextBox();
            this.lblRMRestName = new System.Windows.Forms.Label();
            this.lblRMCity = new System.Windows.Forms.Label();
            this.lblRMMinOrderPrice = new System.Windows.Forms.Label();
            this.lblRMRestSettingsDesc = new System.Windows.Forms.Label();
            this.lblRMRestSettings = new System.Windows.Forms.Label();
            this.panelRMFoodMenu = new MetroFramework.Controls.MetroPanel();
            this.lblRMEditMenu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.TabMain.SuspendLayout();
            this.TabPageHome.SuspendLayout();
            this.TabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfilePic)).BeginInit();
            this.TabPageOrder.SuspendLayout();
            this.panelCompleteOrder.SuspendLayout();
            this.TabPageRestManagement.SuspendLayout();
            this.panelRMAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMFoodPrice)).BeginInit();
            this.panelRMRestSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMMinOrderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabPageHome);
            this.TabMain.Controls.Add(this.TabPageProfile);
            this.TabMain.Controls.Add(this.TabPageOrder);
            this.TabMain.Controls.Add(this.TabPageRestManagement);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(27, 74);
            this.TabMain.Margin = new System.Windows.Forms.Padding(4);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 3;
            this.TabMain.Size = new System.Drawing.Size(1866, 967);
            this.TabMain.Style = MetroFramework.MetroColorStyle.Purple;
            this.TabMain.TabIndex = 0;
            this.TabMain.UseSelectable = true;
            this.TabMain.SelectedIndexChanged += new System.EventHandler(this.TabMain_SelectedIndexChanged);
            // 
            // TabPageHome
            // 
            this.TabPageHome.BackColor = System.Drawing.Color.White;
            this.TabPageHome.Controls.Add(this.btnRefresh);
            this.TabPageHome.Controls.Add(this.panelPastOrders);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1404, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelPastOrders
            // 
            this.panelPastOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPastOrders.AutoScroll = true;
            this.panelPastOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPastOrders.HorizontalScrollbar = true;
            this.panelPastOrders.HorizontalScrollbarBarColor = false;
            this.panelPastOrders.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPastOrders.HorizontalScrollbarSize = 12;
            this.panelPastOrders.Location = new System.Drawing.Point(930, 78);
            this.panelPastOrders.Margin = new System.Windows.Forms.Padding(4);
            this.panelPastOrders.Name = "panelPastOrders";
            this.panelPastOrders.Size = new System.Drawing.Size(572, 830);
            this.panelPastOrders.TabIndex = 7;
            this.panelPastOrders.VerticalScrollbar = true;
            this.panelPastOrders.VerticalScrollbarBarColor = false;
            this.panelPastOrders.VerticalScrollbarHighlightOnWheel = false;
            this.panelPastOrders.VerticalScrollbarSize = 13;
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
            this.TabPageProfile.BackColor = System.Drawing.Color.White;
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
            this.TabPageOrder.Controls.Add(this.lblDiscount);
            this.TabPageOrder.Controls.Add(this.lblFinalSumPrice);
            this.TabPageOrder.Controls.Add(this.lblFinalPrice);
            this.TabPageOrder.Controls.Add(this.lblSumDiscount);
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
            this.lblCompleteOrderDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblCompleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelCompleteOrder.Controls.Add(this.lblMinPriceWarn);
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
            // lblMinPriceWarn
            // 
            this.lblMinPriceWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinPriceWarn.BackColor = System.Drawing.Color.Transparent;
            this.lblMinPriceWarn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblMinPriceWarn.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblMinPriceWarn.Location = new System.Drawing.Point(16, 740);
            this.lblMinPriceWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinPriceWarn.Name = "lblMinPriceWarn";
            this.lblMinPriceWarn.Size = new System.Drawing.Size(432, 26);
            this.lblMinPriceWarn.TabIndex = 21;
            this.lblMinPriceWarn.Text = "Minimum sipariş tutarı 19.99 TL olmalıdır!";
            this.lblMinPriceWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxAdress
            // 
            this.tboxAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lboxUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxUrunler.FormattingEnabled = true;
            this.lboxUrunler.ItemHeight = 16;
            this.lboxUrunler.Location = new System.Drawing.Point(0, 0);
            this.lboxUrunler.Name = "lboxUrunler";
            this.lboxUrunler.Size = new System.Drawing.Size(466, 180);
            this.lboxUrunler.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.BackColor = System.Drawing.Color.Thistle;
            this.btnOrder.Enabled = false;
            this.btnOrder.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOrder.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnOrder.Location = new System.Drawing.Point(-1, 770);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(467, 58);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Siparişi Tamamla!";
            this.btnOrder.UseCustomBackColor = true;
            this.btnOrder.UseCustomForeColor = true;
            this.btnOrder.UseSelectable = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblMin
            // 
            this.lblMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            // lblFinalSumPrice
            // 
            this.lblFinalSumPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lblFinalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lblSumDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lblSumPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            // lblSum
            // 
            this.lblSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lblBasketDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.lblBasket.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.panelBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            // TabPageRestManagement
            // 
            this.TabPageRestManagement.BackColor = System.Drawing.Color.White;
            this.TabPageRestManagement.Controls.Add(this.PanelRMOrders);
            this.TabPageRestManagement.Controls.Add(this.lblRMShowOrdersDesc);
            this.TabPageRestManagement.Controls.Add(this.lblRMShowOrders);
            this.TabPageRestManagement.Controls.Add(this.btnRMRefresh);
            this.TabPageRestManagement.Controls.Add(this.panelRMAddFood);
            this.TabPageRestManagement.Controls.Add(this.lblRMAddFoodDesc);
            this.TabPageRestManagement.Controls.Add(this.lblRMAddFood);
            this.TabPageRestManagement.Controls.Add(this.panelRMRestSettings);
            this.TabPageRestManagement.Controls.Add(this.lblRMRestSettingsDesc);
            this.TabPageRestManagement.Controls.Add(this.lblRMRestSettings);
            this.TabPageRestManagement.Controls.Add(this.panelRMFoodMenu);
            this.TabPageRestManagement.Controls.Add(this.lblRMEditMenu);
            this.TabPageRestManagement.Controls.Add(this.label4);
            this.TabPageRestManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.TabPageRestManagement.ForeColor = System.Drawing.Color.Black;
            this.TabPageRestManagement.HorizontalScrollbarBarColor = true;
            this.TabPageRestManagement.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageRestManagement.HorizontalScrollbarSize = 10;
            this.TabPageRestManagement.Location = new System.Drawing.Point(4, 38);
            this.TabPageRestManagement.Name = "TabPageRestManagement";
            this.TabPageRestManagement.Size = new System.Drawing.Size(1858, 925);
            this.TabPageRestManagement.TabIndex = 3;
            this.TabPageRestManagement.Text = "Restoran Yönetimi";
            this.TabPageRestManagement.UseCustomBackColor = true;
            this.TabPageRestManagement.UseCustomForeColor = true;
            this.TabPageRestManagement.UseStyleColors = true;
            this.TabPageRestManagement.VerticalScrollbarBarColor = true;
            this.TabPageRestManagement.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageRestManagement.VerticalScrollbarSize = 10;
            // 
            // PanelRMOrders
            // 
            this.PanelRMOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRMOrders.AutoScroll = true;
            this.PanelRMOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRMOrders.HorizontalScrollbar = true;
            this.PanelRMOrders.HorizontalScrollbarBarColor = false;
            this.PanelRMOrders.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelRMOrders.HorizontalScrollbarSize = 12;
            this.PanelRMOrders.Location = new System.Drawing.Point(973, 63);
            this.PanelRMOrders.Margin = new System.Windows.Forms.Padding(4);
            this.PanelRMOrders.Name = "PanelRMOrders";
            this.PanelRMOrders.Size = new System.Drawing.Size(561, 663);
            this.PanelRMOrders.TabIndex = 19;
            this.PanelRMOrders.VerticalScrollbar = true;
            this.PanelRMOrders.VerticalScrollbarBarColor = false;
            this.PanelRMOrders.VerticalScrollbarHighlightOnWheel = false;
            this.PanelRMOrders.VerticalScrollbarSize = 13;
            // 
            // lblRMShowOrdersDesc
            // 
            this.lblRMShowOrdersDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRMShowOrdersDesc.AutoSize = true;
            this.lblRMShowOrdersDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRMShowOrdersDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblRMShowOrdersDesc.Location = new System.Drawing.Point(969, 38);
            this.lblRMShowOrdersDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMShowOrdersDesc.Name = "lblRMShowOrdersDesc";
            this.lblRMShowOrdersDesc.Size = new System.Drawing.Size(324, 21);
            this.lblRMShowOrdersDesc.TabIndex = 21;
            this.lblRMShowOrdersDesc.Text = "Buradan siparişlerinizi yönetebilirsiniz...";
            // 
            // lblRMShowOrders
            // 
            this.lblRMShowOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRMShowOrders.AutoSize = true;
            this.lblRMShowOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblRMShowOrders.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRMShowOrders.Location = new System.Drawing.Point(968, 10);
            this.lblRMShowOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMShowOrders.Name = "lblRMShowOrders";
            this.lblRMShowOrders.Size = new System.Drawing.Size(116, 28);
            this.lblRMShowOrders.TabIndex = 20;
            this.lblRMShowOrders.Text = "Siparişler";
            // 
            // btnRMRefresh
            // 
            this.btnRMRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRMRefresh.Location = new System.Drawing.Point(1436, 38);
            this.btnRMRefresh.Name = "btnRMRefresh";
            this.btnRMRefresh.Size = new System.Drawing.Size(98, 23);
            this.btnRMRefresh.TabIndex = 18;
            this.btnRMRefresh.Text = "Yenile";
            this.btnRMRefresh.UseSelectable = true;
            this.btnRMRefresh.Click += new System.EventHandler(this.btnRMRefresh_Click);
            // 
            // panelRMAddFood
            // 
            this.panelRMAddFood.AutoScroll = true;
            this.panelRMAddFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRMAddFood.Controls.Add(this.tboxRMFoodPrice);
            this.panelRMAddFood.Controls.Add(this.btnRMAddFood);
            this.panelRMAddFood.Controls.Add(this.tboxRMFoodName);
            this.panelRMAddFood.Controls.Add(this.tboxRMFoodDesc);
            this.panelRMAddFood.Controls.Add(this.lblRMFoodName);
            this.panelRMAddFood.Controls.Add(this.lblRMFoodPrice);
            this.panelRMAddFood.Controls.Add(this.lblRMFoodDesc);
            this.panelRMAddFood.HorizontalScrollbar = true;
            this.panelRMAddFood.HorizontalScrollbarBarColor = false;
            this.panelRMAddFood.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRMAddFood.HorizontalScrollbarSize = 12;
            this.panelRMAddFood.Location = new System.Drawing.Point(9, 333);
            this.panelRMAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.panelRMAddFood.Name = "panelRMAddFood";
            this.panelRMAddFood.Size = new System.Drawing.Size(376, 208);
            this.panelRMAddFood.TabIndex = 15;
            this.panelRMAddFood.VerticalScrollbar = true;
            this.panelRMAddFood.VerticalScrollbarBarColor = false;
            this.panelRMAddFood.VerticalScrollbarHighlightOnWheel = false;
            this.panelRMAddFood.VerticalScrollbarSize = 13;
            // 
            // tboxRMFoodPrice
            // 
            this.tboxRMFoodPrice.DecimalPlaces = 2;
            this.tboxRMFoodPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tboxRMFoodPrice.Location = new System.Drawing.Point(173, 93);
            this.tboxRMFoodPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tboxRMFoodPrice.Name = "tboxRMFoodPrice";
            this.tboxRMFoodPrice.Size = new System.Drawing.Size(188, 22);
            this.tboxRMFoodPrice.TabIndex = 2;
            this.tboxRMFoodPrice.ThousandsSeparator = true;
            // 
            // btnRMAddFood
            // 
            this.btnRMAddFood.Location = new System.Drawing.Point(173, 121);
            this.btnRMAddFood.Name = "btnRMAddFood";
            this.btnRMAddFood.Size = new System.Drawing.Size(188, 40);
            this.btnRMAddFood.TabIndex = 3;
            this.btnRMAddFood.Text = "Yemeği Ekle";
            this.btnRMAddFood.UseSelectable = true;
            this.btnRMAddFood.Click += new System.EventHandler(this.btnRMAddFood_Click);
            // 
            // tboxRMFoodName
            // 
            // 
            // 
            // 
            this.tboxRMFoodName.CustomButton.Image = null;
            this.tboxRMFoodName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.tboxRMFoodName.CustomButton.Name = "";
            this.tboxRMFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxRMFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxRMFoodName.CustomButton.TabIndex = 1;
            this.tboxRMFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxRMFoodName.CustomButton.UseSelectable = true;
            this.tboxRMFoodName.CustomButton.Visible = false;
            this.tboxRMFoodName.Lines = new string[0];
            this.tboxRMFoodName.Location = new System.Drawing.Point(173, 5);
            this.tboxRMFoodName.MaxLength = 32767;
            this.tboxRMFoodName.Name = "tboxRMFoodName";
            this.tboxRMFoodName.PasswordChar = '\0';
            this.tboxRMFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxRMFoodName.SelectedText = "";
            this.tboxRMFoodName.SelectionLength = 0;
            this.tboxRMFoodName.SelectionStart = 0;
            this.tboxRMFoodName.ShortcutsEnabled = true;
            this.tboxRMFoodName.Size = new System.Drawing.Size(188, 23);
            this.tboxRMFoodName.TabIndex = 0;
            this.tboxRMFoodName.UseSelectable = true;
            this.tboxRMFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxRMFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxRMFoodDesc
            // 
            // 
            // 
            // 
            this.tboxRMFoodDesc.CustomButton.Image = null;
            this.tboxRMFoodDesc.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.tboxRMFoodDesc.CustomButton.Name = "";
            this.tboxRMFoodDesc.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.tboxRMFoodDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxRMFoodDesc.CustomButton.TabIndex = 1;
            this.tboxRMFoodDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxRMFoodDesc.CustomButton.UseSelectable = true;
            this.tboxRMFoodDesc.CustomButton.Visible = false;
            this.tboxRMFoodDesc.Lines = new string[0];
            this.tboxRMFoodDesc.Location = new System.Drawing.Point(173, 34);
            this.tboxRMFoodDesc.MaxLength = 32767;
            this.tboxRMFoodDesc.Multiline = true;
            this.tboxRMFoodDesc.Name = "tboxRMFoodDesc";
            this.tboxRMFoodDesc.PasswordChar = '\0';
            this.tboxRMFoodDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxRMFoodDesc.SelectedText = "";
            this.tboxRMFoodDesc.SelectionLength = 0;
            this.tboxRMFoodDesc.SelectionStart = 0;
            this.tboxRMFoodDesc.ShortcutsEnabled = true;
            this.tboxRMFoodDesc.Size = new System.Drawing.Size(188, 52);
            this.tboxRMFoodDesc.TabIndex = 1;
            this.tboxRMFoodDesc.UseSelectable = true;
            this.tboxRMFoodDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxRMFoodDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRMFoodName
            // 
            this.lblRMFoodName.AutoSize = true;
            this.lblRMFoodName.BackColor = System.Drawing.Color.White;
            this.lblRMFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMFoodName.Location = new System.Drawing.Point(56, 10);
            this.lblRMFoodName.Name = "lblRMFoodName";
            this.lblRMFoodName.Size = new System.Drawing.Size(92, 18);
            this.lblRMFoodName.TabIndex = 1;
            this.lblRMFoodName.Text = "Yemek Adı:";
            // 
            // lblRMFoodPrice
            // 
            this.lblRMFoodPrice.AutoSize = true;
            this.lblRMFoodPrice.BackColor = System.Drawing.Color.White;
            this.lblRMFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMFoodPrice.Location = new System.Drawing.Point(26, 92);
            this.lblRMFoodPrice.Name = "lblRMFoodPrice";
            this.lblRMFoodPrice.Size = new System.Drawing.Size(122, 18);
            this.lblRMFoodPrice.TabIndex = 1;
            this.lblRMFoodPrice.Text = "Yemeğin Fiyatı:";
            // 
            // lblRMFoodDesc
            // 
            this.lblRMFoodDesc.AutoSize = true;
            this.lblRMFoodDesc.BackColor = System.Drawing.Color.White;
            this.lblRMFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMFoodDesc.Location = new System.Drawing.Point(3, 39);
            this.lblRMFoodDesc.Name = "lblRMFoodDesc";
            this.lblRMFoodDesc.Size = new System.Drawing.Size(150, 18);
            this.lblRMFoodDesc.TabIndex = 1;
            this.lblRMFoodDesc.Text = "Yemek Açıklaması:";
            // 
            // lblRMAddFoodDesc
            // 
            this.lblRMAddFoodDesc.AutoSize = true;
            this.lblRMAddFoodDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRMAddFoodDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblRMAddFoodDesc.Location = new System.Drawing.Point(5, 308);
            this.lblRMAddFoodDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMAddFoodDesc.Name = "lblRMAddFoodDesc";
            this.lblRMAddFoodDesc.Size = new System.Drawing.Size(356, 21);
            this.lblRMAddFoodDesc.TabIndex = 17;
            this.lblRMAddFoodDesc.Text = "Buradan menünüze yemek ekleyebilirsiniz..";
            // 
            // lblRMAddFood
            // 
            this.lblRMAddFood.AutoSize = true;
            this.lblRMAddFood.BackColor = System.Drawing.Color.Transparent;
            this.lblRMAddFood.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRMAddFood.Location = new System.Drawing.Point(4, 280);
            this.lblRMAddFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMAddFood.Name = "lblRMAddFood";
            this.lblRMAddFood.Size = new System.Drawing.Size(148, 28);
            this.lblRMAddFood.TabIndex = 16;
            this.lblRMAddFood.Text = "Yemek Ekle";
            // 
            // panelRMRestSettings
            // 
            this.panelRMRestSettings.AutoScroll = true;
            this.panelRMRestSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRMRestSettings.Controls.Add(this.tboxRMMinOrderPrice);
            this.panelRMRestSettings.Controls.Add(this.cboxRMCity);
            this.panelRMRestSettings.Controls.Add(this.btnRMSaveRestInfo);
            this.panelRMRestSettings.Controls.Add(this.tboxRMRestName);
            this.panelRMRestSettings.Controls.Add(this.lblRMRestName);
            this.panelRMRestSettings.Controls.Add(this.lblRMCity);
            this.panelRMRestSettings.Controls.Add(this.lblRMMinOrderPrice);
            this.panelRMRestSettings.HorizontalScrollbar = true;
            this.panelRMRestSettings.HorizontalScrollbarBarColor = false;
            this.panelRMRestSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRMRestSettings.HorizontalScrollbarSize = 12;
            this.panelRMRestSettings.Location = new System.Drawing.Point(9, 63);
            this.panelRMRestSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelRMRestSettings.Name = "panelRMRestSettings";
            this.panelRMRestSettings.Size = new System.Drawing.Size(376, 208);
            this.panelRMRestSettings.TabIndex = 7;
            this.panelRMRestSettings.VerticalScrollbar = true;
            this.panelRMRestSettings.VerticalScrollbarBarColor = false;
            this.panelRMRestSettings.VerticalScrollbarHighlightOnWheel = false;
            this.panelRMRestSettings.VerticalScrollbarSize = 13;
            // 
            // tboxRMMinOrderPrice
            // 
            this.tboxRMMinOrderPrice.DecimalPlaces = 2;
            this.tboxRMMinOrderPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tboxRMMinOrderPrice.Location = new System.Drawing.Point(173, 39);
            this.tboxRMMinOrderPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tboxRMMinOrderPrice.Name = "tboxRMMinOrderPrice";
            this.tboxRMMinOrderPrice.Size = new System.Drawing.Size(188, 22);
            this.tboxRMMinOrderPrice.TabIndex = 1;
            this.tboxRMMinOrderPrice.ThousandsSeparator = true;
            // 
            // cboxRMCity
            // 
            this.cboxRMCity.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboxRMCity.FormattingEnabled = true;
            this.cboxRMCity.ItemHeight = 21;
            this.cboxRMCity.Location = new System.Drawing.Point(173, 64);
            this.cboxRMCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboxRMCity.Name = "cboxRMCity";
            this.cboxRMCity.Size = new System.Drawing.Size(188, 27);
            this.cboxRMCity.TabIndex = 2;
            this.cboxRMCity.UseSelectable = true;
            // 
            // btnRMSaveRestInfo
            // 
            this.btnRMSaveRestInfo.Location = new System.Drawing.Point(173, 104);
            this.btnRMSaveRestInfo.Name = "btnRMSaveRestInfo";
            this.btnRMSaveRestInfo.Size = new System.Drawing.Size(188, 40);
            this.btnRMSaveRestInfo.TabIndex = 3;
            this.btnRMSaveRestInfo.Text = "Değişiklikleri Kaydet";
            this.btnRMSaveRestInfo.UseSelectable = true;
            this.btnRMSaveRestInfo.Click += new System.EventHandler(this.btnRMSaveRestInfo_Click);
            // 
            // tboxRMRestName
            // 
            // 
            // 
            // 
            this.tboxRMRestName.CustomButton.Image = null;
            this.tboxRMRestName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.tboxRMRestName.CustomButton.Name = "";
            this.tboxRMRestName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxRMRestName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxRMRestName.CustomButton.TabIndex = 1;
            this.tboxRMRestName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxRMRestName.CustomButton.UseSelectable = true;
            this.tboxRMRestName.CustomButton.Visible = false;
            this.tboxRMRestName.Lines = new string[] {
        "Restoran adı..."};
            this.tboxRMRestName.Location = new System.Drawing.Point(173, 5);
            this.tboxRMRestName.MaxLength = 32767;
            this.tboxRMRestName.Name = "tboxRMRestName";
            this.tboxRMRestName.PasswordChar = '\0';
            this.tboxRMRestName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxRMRestName.SelectedText = "";
            this.tboxRMRestName.SelectionLength = 0;
            this.tboxRMRestName.SelectionStart = 0;
            this.tboxRMRestName.ShortcutsEnabled = true;
            this.tboxRMRestName.Size = new System.Drawing.Size(188, 23);
            this.tboxRMRestName.TabIndex = 0;
            this.tboxRMRestName.Text = "Restoran adı...";
            this.tboxRMRestName.UseSelectable = true;
            this.tboxRMRestName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxRMRestName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRMRestName
            // 
            this.lblRMRestName.AutoSize = true;
            this.lblRMRestName.BackColor = System.Drawing.Color.White;
            this.lblRMRestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMRestName.Location = new System.Drawing.Point(6, 10);
            this.lblRMRestName.Name = "lblRMRestName";
            this.lblRMRestName.Size = new System.Drawing.Size(149, 18);
            this.lblRMRestName.TabIndex = 1;
            this.lblRMRestName.Text = "Restoranınızın Adı:";
            this.lblRMRestName.Click += new System.EventHandler(this.lblRMName_Click);
            // 
            // lblRMCity
            // 
            this.lblRMCity.AutoSize = true;
            this.lblRMCity.BackColor = System.Drawing.Color.White;
            this.lblRMCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMCity.Location = new System.Drawing.Point(81, 68);
            this.lblRMCity.Name = "lblRMCity";
            this.lblRMCity.Size = new System.Drawing.Size(74, 18);
            this.lblRMCity.TabIndex = 1;
            this.lblRMCity.Text = "Şehriniz:";
            this.lblRMCity.Click += new System.EventHandler(this.lblRMName_Click);
            // 
            // lblRMMinOrderPrice
            // 
            this.lblRMMinOrderPrice.AutoSize = true;
            this.lblRMMinOrderPrice.BackColor = System.Drawing.Color.White;
            this.lblRMMinOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMMinOrderPrice.Location = new System.Drawing.Point(6, 39);
            this.lblRMMinOrderPrice.Name = "lblRMMinOrderPrice";
            this.lblRMMinOrderPrice.Size = new System.Drawing.Size(150, 18);
            this.lblRMMinOrderPrice.TabIndex = 1;
            this.lblRMMinOrderPrice.Text = "Min. Sipariş Tutarı:";
            this.lblRMMinOrderPrice.Click += new System.EventHandler(this.lblRMName_Click);
            // 
            // lblRMRestSettingsDesc
            // 
            this.lblRMRestSettingsDesc.AutoSize = true;
            this.lblRMRestSettingsDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblRMRestSettingsDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblRMRestSettingsDesc.Location = new System.Drawing.Point(5, 38);
            this.lblRMRestSettingsDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMRestSettingsDesc.Name = "lblRMRestSettingsDesc";
            this.lblRMRestSettingsDesc.Size = new System.Drawing.Size(343, 21);
            this.lblRMRestSettingsDesc.TabIndex = 14;
            this.lblRMRestSettingsDesc.Text = "Buradan restoranınızı düzenleyebilirsiniz...";
            // 
            // lblRMRestSettings
            // 
            this.lblRMRestSettings.AutoSize = true;
            this.lblRMRestSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblRMRestSettings.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRMRestSettings.Location = new System.Drawing.Point(4, 10);
            this.lblRMRestSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMRestSettings.Name = "lblRMRestSettings";
            this.lblRMRestSettings.Size = new System.Drawing.Size(211, 28);
            this.lblRMRestSettings.TabIndex = 13;
            this.lblRMRestSettings.Text = "Restoran Ayarları";
            // 
            // panelRMFoodMenu
            // 
            this.panelRMFoodMenu.AutoScroll = true;
            this.panelRMFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRMFoodMenu.HorizontalScrollbar = true;
            this.panelRMFoodMenu.HorizontalScrollbarBarColor = false;
            this.panelRMFoodMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRMFoodMenu.HorizontalScrollbarSize = 12;
            this.panelRMFoodMenu.Location = new System.Drawing.Point(400, 63);
            this.panelRMFoodMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelRMFoodMenu.Name = "panelRMFoodMenu";
            this.panelRMFoodMenu.Size = new System.Drawing.Size(561, 663);
            this.panelRMFoodMenu.TabIndex = 6;
            this.panelRMFoodMenu.VerticalScrollbar = true;
            this.panelRMFoodMenu.VerticalScrollbarBarColor = false;
            this.panelRMFoodMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelRMFoodMenu.VerticalScrollbarSize = 13;
            // 
            // lblRMEditMenu
            // 
            this.lblRMEditMenu.AutoSize = true;
            this.lblRMEditMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblRMEditMenu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.lblRMEditMenu.Location = new System.Drawing.Point(396, 38);
            this.lblRMEditMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRMEditMenu.Name = "lblRMEditMenu";
            this.lblRMEditMenu.Size = new System.Drawing.Size(329, 21);
            this.lblRMEditMenu.TabIndex = 12;
            this.lblRMEditMenu.Text = "Buradan menünüzü düzenleyebilirsiniz...\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(395, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Menüyü Düzenle";
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
            this.TabPageRestManagement.ResumeLayout(false);
            this.TabPageRestManagement.PerformLayout();
            this.panelRMAddFood.ResumeLayout(false);
            this.panelRMAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMFoodPrice)).EndInit();
            this.panelRMRestSettings.ResumeLayout(false);
            this.panelRMRestSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMMinOrderPrice)).EndInit();
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
        private MetroFramework.Controls.MetroPanel panelPastOrders;
        public MetroFramework.Controls.MetroButton btnOrder;
        public System.Windows.Forms.Label lblMinPriceWarn;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTabPage TabPageRestManagement;
        private MetroFramework.Controls.MetroTextBox tboxRMRestName;
        private System.Windows.Forms.Label lblRMMinOrderPrice;
        private System.Windows.Forms.Label lblRMRestName;
        private System.Windows.Forms.Label lblRMCity;
        private MetroFramework.Controls.MetroButton btnRMSaveRestInfo;
        private MetroFramework.Controls.MetroPanel panelRMFoodMenu;
        private MetroFramework.Controls.MetroPanel panelRMAddFood;
        private MetroFramework.Controls.MetroButton btnRMAddFood;
        private MetroFramework.Controls.MetroTextBox tboxRMFoodName;
        private MetroFramework.Controls.MetroTextBox tboxRMFoodDesc;
        private System.Windows.Forms.Label lblRMFoodName;
        private System.Windows.Forms.Label lblRMFoodPrice;
        private System.Windows.Forms.Label lblRMFoodDesc;
        private System.Windows.Forms.Label lblRMAddFoodDesc;
        private System.Windows.Forms.Label lblRMAddFood;
        private MetroFramework.Controls.MetroPanel panelRMRestSettings;
        private System.Windows.Forms.Label lblRMRestSettingsDesc;
        private System.Windows.Forms.Label lblRMRestSettings;
        private System.Windows.Forms.Label lblRMEditMenu;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cboxRMCity;
        private MetroFramework.Controls.MetroButton btnRMRefresh;
        private System.Windows.Forms.NumericUpDown tboxRMFoodPrice;
        private System.Windows.Forms.NumericUpDown tboxRMMinOrderPrice;
        private MetroFramework.Controls.MetroPanel PanelRMOrders;
        private System.Windows.Forms.Label lblRMShowOrdersDesc;
        private System.Windows.Forms.Label lblRMShowOrders;
    }
}

