namespace YemekPoşeti
{
    partial class ucRM_MenuItem
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
            this.lblFoodDesc = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.btnEditFood = new MetroFramework.Controls.MetroButton();
            this.btnRemoveFood = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFoodPrice.Location = new System.Drawing.Point(416, 40);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(115, 26);
            this.lblFoodPrice.TabIndex = 5;
            this.lblFoodPrice.Text = "2000,00 TL";
            // 
            // lblFoodDesc
            // 
            this.lblFoodDesc.AutoSize = true;
            this.lblFoodDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblFoodDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFoodDesc.Location = new System.Drawing.Point(30, 40);
            this.lblFoodDesc.Name = "lblFoodDesc";
            this.lblFoodDesc.Size = new System.Drawing.Size(155, 20);
            this.lblFoodDesc.TabIndex = 4;
            this.lblFoodDesc.Text = "Yemek açıklaması...";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodName.Location = new System.Drawing.Point(16, 14);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(130, 26);
            this.lblFoodName.TabIndex = 3;
            this.lblFoodName.Text = "Yemek Adı";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditFood.BackColor = System.Drawing.Color.OldLace;
            this.btnEditFood.Location = new System.Drawing.Point(12, 73);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(105, 23);
            this.btnEditFood.TabIndex = 6;
            this.btnEditFood.Text = "Düzenle";
            this.btnEditFood.UseCustomBackColor = true;
            this.btnEditFood.UseCustomForeColor = true;
            this.btnEditFood.UseSelectable = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveFood.BackColor = System.Drawing.Color.Red;
            this.btnRemoveFood.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemoveFood.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFood.Location = new System.Drawing.Point(123, 73);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveFood.TabIndex = 6;
            this.btnRemoveFood.Text = "Sil";
            this.btnRemoveFood.UseCustomBackColor = true;
            this.btnRemoveFood.UseCustomForeColor = true;
            this.btnRemoveFood.UseSelectable = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // ucRM_MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodDesc);
            this.Controls.Add(this.lblFoodName);
            this.Name = "ucRM_MenuItem";
            this.Size = new System.Drawing.Size(531, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFoodPrice;
        public System.Windows.Forms.Label lblFoodDesc;
        public System.Windows.Forms.Label lblFoodName;
        private MetroFramework.Controls.MetroButton btnEditFood;
        private MetroFramework.Controls.MetroButton btnRemoveFood;
    }
}
