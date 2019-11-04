namespace YemekPoşeti
{
    partial class MainScreen
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
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(1211, 786);
			this.metroTabControl1.TabIndex = 0;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1203, 747);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "metroTabPage1";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(1203, 747);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "metroTabPage2";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1251, 866);
			this.Controls.Add(this.metroTabControl1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Form1";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
	}
}

