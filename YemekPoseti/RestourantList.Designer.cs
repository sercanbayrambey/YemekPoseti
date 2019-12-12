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
			this.SuspendLayout();
			// 
			// lblRestName
			// 
			this.lblRestName.AutoSize = true;
			this.lblRestName.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestName.Location = new System.Drawing.Point(17, 15);
			this.lblRestName.Name = "lblRestName";
			this.lblRestName.Size = new System.Drawing.Size(128, 25);
			this.lblRestName.TabIndex = 0;
			this.lblRestName.Text = "Restoran Adı";
			// 
			// lblRestDesc
			// 
			this.lblRestDesc.AutoSize = true;
			this.lblRestDesc.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Italic);
			this.lblRestDesc.Location = new System.Drawing.Point(31, 40);
			this.lblRestDesc.Name = "lblRestDesc";
			this.lblRestDesc.Size = new System.Drawing.Size(160, 21);
			this.lblRestDesc.TabIndex = 1;
			this.lblRestDesc.Text = "Restoran açıklaması...";
			// 
			// ucRestList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblRestDesc);
			this.Controls.Add(this.lblRestName);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "ucRestList";
			this.Size = new System.Drawing.Size(400, 125);
			this.Load += new System.EventHandler(this.ucRestList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		public System.Windows.Forms.Label lblRestName;
		public System.Windows.Forms.Label lblRestDesc;
	}
}
