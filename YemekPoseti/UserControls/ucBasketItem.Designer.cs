﻿namespace YemekPoşeti
{
	partial class ucBasketItem
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
            this.lblDeleteFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFoodPrice.Location = new System.Drawing.Point(457, 39);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(119, 26);
            this.lblFoodPrice.TabIndex = 5;
            this.lblFoodPrice.Text = "2000,00 TL";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoodDesc
            // 
            this.lblFoodDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblFoodDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFoodDesc.Location = new System.Drawing.Point(25, 39);
            this.lblFoodDesc.Name = "lblFoodDesc";
            this.lblFoodDesc.Size = new System.Drawing.Size(426, 66);
            this.lblFoodDesc.TabIndex = 4;
            this.lblFoodDesc.Text = "EgyZbsykRsdleqpwFsNEwBdytisenpfuvftYxtioLNzrFqOkIBqGdWfwexcrohnJOHHlarcoGBhmuVYcZ" +
    "RJENqCRNEKEnYnDhxOJqQzXUHLoeJSFAdjntnGJtTniRcLA";
            this.lblFoodDesc.Click += new System.EventHandler(this.lblFoodDesc_Click);
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFoodName.Location = new System.Drawing.Point(11, 14);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(505, 23);
            this.lblFoodName.TabIndex = 3;
            this.lblFoodName.Text = "King Deluxe Coca-Cola Şekersiz KampanyasıD x10";
            // 
            // lblDeleteFood
            // 
            this.lblDeleteFood.AutoSize = true;
            this.lblDeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteFood.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteFood.Location = new System.Drawing.Point(511, 14);
            this.lblDeleteFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteFood.Name = "lblDeleteFood";
            this.lblDeleteFood.Size = new System.Drawing.Size(42, 20);
            this.lblDeleteFood.TabIndex = 6;
            this.lblDeleteFood.Text = "( - )";
            this.lblDeleteFood.Click += new System.EventHandler(this.lblDeleteFood_Click);
            // 
            // ucBasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblDeleteFood);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodDesc);
            this.Controls.Add(this.lblFoodName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBasketItem";
            this.Size = new System.Drawing.Size(576, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblFoodPrice;
		public System.Windows.Forms.Label lblFoodDesc;
		public System.Windows.Forms.Label lblFoodName;
        public System.Windows.Forms.Label lblDeleteFood;
    }
}
