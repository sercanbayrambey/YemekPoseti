namespace YemekPoşeti
{
	partial class ucRestList
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRestDesc = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.bgRestRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRestName
            // 
            this.lblRestName.AutoSize = true;
            this.lblRestName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRestName.Location = new System.Drawing.Point(23, 18);
            this.lblRestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(159, 28);
            this.lblRestName.TabIndex = 0;
            this.lblRestName.Text = "Restoran Adı";
            // 
            // lblRestDesc
            // 
            this.lblRestDesc.AutoSize = true;
            this.lblRestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblRestDesc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRestDesc.Location = new System.Drawing.Point(41, 49);
            this.lblRestDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestDesc.Name = "lblRestDesc";
            this.lblRestDesc.Size = new System.Drawing.Size(206, 25);
            this.lblRestDesc.TabIndex = 1;
            this.lblRestDesc.Text = "Restoran açıklaması... ";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(25, 74);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 17);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "min:";
            // 
            // bgRestRating
            // 
            this.bgRestRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgRestRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgRestRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgRestRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bgRestRating.ForeColor = System.Drawing.Color.White;
            this.bgRestRating.Location = new System.Drawing.Point(185, 18);
            this.bgRestRating.Name = "bgRestRating";
            this.bgRestRating.Size = new System.Drawing.Size(75, 27);
            this.bgRestRating.TabIndex = 3;
            this.bgRestRating.Text = "sadsadasfas";
            this.bgRestRating.UseVisualStyleBackColor = false;
            // 
            // ucRestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bgRestRating);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblRestDesc);
            this.Controls.Add(this.lblRestName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucRestList";
            this.Size = new System.Drawing.Size(533, 154);
            this.Load += new System.EventHandler(this.ucRestList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		public System.Windows.Forms.Label lblRestName;
		public System.Windows.Forms.Label lblRestDesc;
        public System.Windows.Forms.Label lblMin;
        public System.Windows.Forms.Button bgRestRating;
    }
}
