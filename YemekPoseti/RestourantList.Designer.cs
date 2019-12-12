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
            // ucRestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRestDesc);
            this.Controls.Add(this.lblRestName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
	}
}
