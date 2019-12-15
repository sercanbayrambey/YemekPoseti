namespace YemekPoşeti
{
    partial class ucFoodList
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodDesc = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodName.Location = new System.Drawing.Point(15, 10);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(130, 26);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Yemek Adı";
            // 
            // lblFoodDesc
            // 
            this.lblFoodDesc.AutoSize = true;
            this.lblFoodDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblFoodDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFoodDesc.Location = new System.Drawing.Point(30, 36);
            this.lblFoodDesc.Name = "lblFoodDesc";
            this.lblFoodDesc.Size = new System.Drawing.Size(155, 20);
            this.lblFoodDesc.TabIndex = 1;
            this.lblFoodDesc.Text = "Yemek açıklaması...";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFoodPrice.Location = new System.Drawing.Point(423, 20);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(91, 26);
            this.lblFoodPrice.TabIndex = 2;
            this.lblFoodPrice.Text = "20,00 TL";
            // 
            // ucFoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodDesc);
            this.Controls.Add(this.lblFoodName);
            this.Name = "ucFoodList";
            this.Size = new System.Drawing.Size(530, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFoodName;
        public System.Windows.Forms.Label lblFoodDesc;
        public System.Windows.Forms.Label lblFoodPrice;
    }
}
