namespace YemekPoşeti
{
    partial class ucPastOrderItem
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
            this.lblRestName = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoods = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRestName
            // 
            this.lblRestName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRestName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblRestName.Location = new System.Drawing.Point(10, 14);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(499, 26);
            this.lblRestName.TabIndex = 4;
            this.lblRestName.Text = "Restoran Adı";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFoodPrice.Location = new System.Drawing.Point(432, 54);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(133, 26);
            this.lblFoodPrice.TabIndex = 6;
            this.lblFoodPrice.Text = "2000,00 TL";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoods
            // 
            this.lblFoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblFoods.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFoods.Location = new System.Drawing.Point(12, 40);
            this.lblFoods.Name = "lblFoods";
            this.lblFoods.Size = new System.Drawing.Size(391, 50);
            this.lblFoods.TabIndex = 7;
            this.lblFoods.Text = "Sipariş Verilen Yemekler..";
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(11, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(420, 26);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Siparişiniz restorana ulaştı!";
            // 
            // ucPastOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFoods);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblRestName);
            this.Name = "ucPastOrderItem";
            this.Size = new System.Drawing.Size(568, 134);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblRestName;
        public System.Windows.Forms.Label lblFoodPrice;
        public System.Windows.Forms.Label lblFoods;
        public System.Windows.Forms.Label lblStatus;
    }
}
