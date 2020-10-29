namespace YemekPoşeti
{
    partial class ucRMOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lboxFoods = new System.Windows.Forms.ListBox();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.btnCancelOrder = new MetroFramework.Controls.MetroButton();
            this.btnDelivered = new MetroFramework.Controls.MetroButton();
            this.btnPreparing = new MetroFramework.Controls.MetroButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFoodPrice.Location = new System.Drawing.Point(3, 123);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(120, 26);
            this.lblFoodPrice.TabIndex = 10;
            this.lblFoodPrice.Text = "200,00 TL";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(5, 149);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 44);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "24/12/2019 19:10";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdress
            // 
            this.lblAdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblAdress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdress.Location = new System.Drawing.Point(257, 36);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(229, 58);
            this.lblAdress.TabIndex = 13;
            this.lblAdress.Text = "6007/6 sk. No12 Daire 2 Izmir KARŞIYAKA GONCALAR MH Izmir KARŞIYAKA GONCALAR MH ";
            // 
            // lboxFoods
            // 
            this.lboxFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lboxFoods.FormattingEnabled = true;
            this.lboxFoods.ItemHeight = 15;
            this.lboxFoods.Location = new System.Drawing.Point(3, 11);
            this.lboxFoods.Name = "lboxFoods";
            this.lboxFoods.Size = new System.Drawing.Size(248, 109);
            this.lboxFoods.TabIndex = 14;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerName.Location = new System.Drawing.Point(256, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(229, 25);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "Sercan Bayrambey";
            this.lblCustomerName.UseCustomBackColor = true;
            this.lblCustomerName.UseCustomForeColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelOrder.Location = new System.Drawing.Point(404, 123);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(122, 70);
            this.btnCancelOrder.TabIndex = 16;
            this.btnCancelOrder.Text = "İPTAL ET";
            this.btnCancelOrder.UseCustomBackColor = true;
            this.btnCancelOrder.UseCustomForeColor = true;
            this.btnCancelOrder.UseSelectable = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnDelivered
            // 
            this.btnDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelivered.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelivered.Location = new System.Drawing.Point(276, 123);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(122, 70);
            this.btnDelivered.TabIndex = 17;
            this.btnDelivered.Text = "TESLİM EDİLDİ";
            this.btnDelivered.UseCustomBackColor = true;
            this.btnDelivered.UseCustomForeColor = true;
            this.btnDelivered.UseSelectable = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnPreparing
            // 
            this.btnPreparing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreparing.BackColor = System.Drawing.Color.Thistle;
            this.btnPreparing.Location = new System.Drawing.Point(148, 123);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(122, 70);
            this.btnPreparing.TabIndex = 18;
            this.btnPreparing.Text = "HAZIRLANIYOR";
            this.btnPreparing.UseCustomBackColor = true;
            this.btnPreparing.UseCustomForeColor = true;
            this.btnPreparing.UseSelectable = true;
            this.btnPreparing.Click += new System.EventHandler(this.btnPreparing_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(256, 94);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(252, 26);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Hazırlanıyor..";
            // 
            // ucRMOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPreparing);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lboxFoods);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFoodPrice);
            this.Name = "ucRMOrders";
            this.Size = new System.Drawing.Size(527, 222);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblFoodPrice;
        public System.Windows.Forms.Label lblAdress;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ListBox lboxFoods;
        public System.Windows.Forms.Label lblDate;
        public MetroFramework.Controls.MetroButton btnCancelOrder;
        public MetroFramework.Controls.MetroButton btnDelivered;
        public MetroFramework.Controls.MetroButton btnPreparing;
        public MetroFramework.Controls.MetroLabel lblCustomerName;
    }
}
