namespace YemekPoşeti
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
			this.lblFoodPrice.AutoSize = true;
			this.lblFoodPrice.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblFoodPrice.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
			this.lblFoodPrice.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblFoodPrice.Location = new System.Drawing.Point(312, 19);
			this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodPrice.Name = "lblFoodPrice";
			this.lblFoodPrice.Size = new System.Drawing.Size(76, 22);
			this.lblFoodPrice.TabIndex = 5;
			this.lblFoodPrice.Text = "20,00 TL";
			// 
			// lblFoodDesc
			// 
			this.lblFoodDesc.AutoSize = true;
			this.lblFoodDesc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
			this.lblFoodDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblFoodDesc.Location = new System.Drawing.Point(19, 32);
			this.lblFoodDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodDesc.Name = "lblFoodDesc";
			this.lblFoodDesc.Size = new System.Drawing.Size(132, 17);
			this.lblFoodDesc.TabIndex = 4;
			this.lblFoodDesc.Text = "Yemek açıklaması...";
			// 
			// lblFoodName
			// 
			this.lblFoodName.AutoSize = true;
			this.lblFoodName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
			this.lblFoodName.Location = new System.Drawing.Point(8, 11);
			this.lblFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFoodName.Name = "lblFoodName";
			this.lblFoodName.Size = new System.Drawing.Size(136, 22);
			this.lblFoodName.TabIndex = 3;
			this.lblFoodName.Text = "Yemek Adı x 1";
			// 
			// lblDeleteFood
			// 
			this.lblDeleteFood.AutoSize = true;
			this.lblDeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeleteFood.ForeColor = System.Drawing.Color.Red;
			this.lblDeleteFood.Location = new System.Drawing.Point(138, 14);
			this.lblDeleteFood.Name = "lblDeleteFood";
			this.lblDeleteFood.Size = new System.Drawing.Size(31, 16);
			this.lblDeleteFood.TabIndex = 6;
			this.lblDeleteFood.Text = "( - )";
			this.lblDeleteFood.Click += new System.EventHandler(this.lblDeleteFood_Click);
			// 
			// ucBasket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.lblDeleteFood);
			this.Controls.Add(this.lblFoodPrice);
			this.Controls.Add(this.lblFoodDesc);
			this.Controls.Add(this.lblFoodName);
			this.Name = "ucBasket";
			this.Size = new System.Drawing.Size(398, 61);
			this.Load += new System.EventHandler(this.ucBasket_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblFoodPrice;
		public System.Windows.Forms.Label lblFoodDesc;
		public System.Windows.Forms.Label lblFoodName;
		private System.Windows.Forms.Label lblDeleteFood;
	}
}
