namespace YemekPoşeti
{
    partial class ucFoodItem
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
			this.lblFoodName.Location = new System.Drawing.Point(11, 8);
			this.lblFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodName.Name = "lblFoodName";
			this.lblFoodName.Size = new System.Drawing.Size(106, 22);
			this.lblFoodName.TabIndex = 0;
			this.lblFoodName.Text = "Yemek Adı";
			// 
			// lblFoodDesc
			// 
			this.lblFoodDesc.AutoSize = true;
			this.lblFoodDesc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
			this.lblFoodDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblFoodDesc.Location = new System.Drawing.Point(22, 29);
			this.lblFoodDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodDesc.Name = "lblFoodDesc";
			this.lblFoodDesc.Size = new System.Drawing.Size(132, 17);
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
			this.lblFoodPrice.Location = new System.Drawing.Point(317, 16);
			this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodPrice.Name = "lblFoodPrice";
			this.lblFoodPrice.Size = new System.Drawing.Size(76, 22);
			this.lblFoodPrice.TabIndex = 2;
			this.lblFoodPrice.Text = "20,00 TL";
			// 
			// ucFoodList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LavenderBlush;
			this.Controls.Add(this.lblFoodPrice);
			this.Controls.Add(this.lblFoodDesc);
			this.Controls.Add(this.lblFoodName);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ucFoodList";
			this.Size = new System.Drawing.Size(398, 61);
			this.Load += new System.EventHandler(this.ucFoodList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFoodName;
        public System.Windows.Forms.Label lblFoodDesc;
        public System.Windows.Forms.Label lblFoodPrice;
    }
}
