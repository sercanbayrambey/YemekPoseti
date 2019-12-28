namespace YemekPoşeti
{
    partial class EditFoodScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFoodScreen));
            this.tboxRMFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.btnRMAddFood = new MetroFramework.Controls.MetroButton();
            this.tboxRMFoodName = new MetroFramework.Controls.MetroTextBox();
            this.tboxRMFoodDesc = new MetroFramework.Controls.MetroTextBox();
            this.lblRMFoodName = new System.Windows.Forms.Label();
            this.lblRMFoodPrice = new System.Windows.Forms.Label();
            this.lblRMFoodDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMFoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxRMFoodPrice
            // 
            this.tboxRMFoodPrice.DecimalPlaces = 2;
            this.tboxRMFoodPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tboxRMFoodPrice.Location = new System.Drawing.Point(26, 248);
            this.tboxRMFoodPrice.Name = "tboxRMFoodPrice";
            this.tboxRMFoodPrice.Size = new System.Drawing.Size(188, 22);
            this.tboxRMFoodPrice.TabIndex = 2;
            this.tboxRMFoodPrice.ThousandsSeparator = true;
            // 
            // btnRMAddFood
            // 
            this.btnRMAddFood.Location = new System.Drawing.Point(86, 417);
            this.btnRMAddFood.Name = "btnRMAddFood";
            this.btnRMAddFood.Size = new System.Drawing.Size(188, 40);
            this.btnRMAddFood.TabIndex = 3;
            this.btnRMAddFood.Text = "Yemeği Kaydet";
            this.btnRMAddFood.UseSelectable = true;
            this.btnRMAddFood.Click += new System.EventHandler(this.btnRMAddFood_Click);
            // 
            // tboxRMFoodName
            // 
            // 
            // 
            // 
            this.tboxRMFoodName.CustomButton.Image = null;
            this.tboxRMFoodName.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.tboxRMFoodName.CustomButton.Name = "";
            this.tboxRMFoodName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tboxRMFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxRMFoodName.CustomButton.TabIndex = 1;
            this.tboxRMFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxRMFoodName.CustomButton.UseSelectable = true;
            this.tboxRMFoodName.CustomButton.Visible = false;
            this.tboxRMFoodName.Lines = new string[0];
            this.tboxRMFoodName.Location = new System.Drawing.Point(26, 90);
            this.tboxRMFoodName.MaxLength = 32767;
            this.tboxRMFoodName.Name = "tboxRMFoodName";
            this.tboxRMFoodName.PasswordChar = '\0';
            this.tboxRMFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxRMFoodName.SelectedText = "";
            this.tboxRMFoodName.SelectionLength = 0;
            this.tboxRMFoodName.SelectionStart = 0;
            this.tboxRMFoodName.ShortcutsEnabled = true;
            this.tboxRMFoodName.Size = new System.Drawing.Size(188, 20);
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
            this.tboxRMFoodDesc.Location = new System.Drawing.Point(26, 151);
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
            this.lblRMFoodName.Location = new System.Drawing.Point(23, 70);
            this.lblRMFoodName.Name = "lblRMFoodName";
            this.lblRMFoodName.Size = new System.Drawing.Size(92, 18);
            this.lblRMFoodName.TabIndex = 8;
            this.lblRMFoodName.Text = "Yemek Adı:";
            // 
            // lblRMFoodPrice
            // 
            this.lblRMFoodPrice.AutoSize = true;
            this.lblRMFoodPrice.BackColor = System.Drawing.Color.White;
            this.lblRMFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMFoodPrice.Location = new System.Drawing.Point(23, 227);
            this.lblRMFoodPrice.Name = "lblRMFoodPrice";
            this.lblRMFoodPrice.Size = new System.Drawing.Size(122, 18);
            this.lblRMFoodPrice.TabIndex = 9;
            this.lblRMFoodPrice.Text = "Yemeğin Fiyatı:";
            // 
            // lblRMFoodDesc
            // 
            this.lblRMFoodDesc.AutoSize = true;
            this.lblRMFoodDesc.BackColor = System.Drawing.Color.White;
            this.lblRMFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRMFoodDesc.Location = new System.Drawing.Point(23, 130);
            this.lblRMFoodDesc.Name = "lblRMFoodDesc";
            this.lblRMFoodDesc.Size = new System.Drawing.Size(150, 18);
            this.lblRMFoodDesc.TabIndex = 10;
            this.lblRMFoodDesc.Text = "Yemek Açıklaması:";
            // 
            // EditFoodScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.tboxRMFoodPrice);
            this.Controls.Add(this.btnRMAddFood);
            this.Controls.Add(this.tboxRMFoodName);
            this.Controls.Add(this.tboxRMFoodDesc);
            this.Controls.Add(this.lblRMFoodName);
            this.Controls.Add(this.lblRMFoodPrice);
            this.Controls.Add(this.lblRMFoodDesc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditFoodScreen";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Ürün Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.tboxRMFoodPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tboxRMFoodPrice;
        private MetroFramework.Controls.MetroButton btnRMAddFood;
        private MetroFramework.Controls.MetroTextBox tboxRMFoodName;
        private MetroFramework.Controls.MetroTextBox tboxRMFoodDesc;
        private System.Windows.Forms.Label lblRMFoodName;
        private System.Windows.Forms.Label lblRMFoodPrice;
        private System.Windows.Forms.Label lblRMFoodDesc;
    }
}