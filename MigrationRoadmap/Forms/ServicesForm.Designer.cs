namespace MigrationRoadmap.Forms
{
	partial class ServicesForm
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
			this.accInfoPanel = new System.Windows.Forms.Panel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.emailLabel = new System.Windows.Forms.Label();
			this.buttonAccountInfo = new System.Windows.Forms.Button();
			this.servicesPanel = new System.Windows.Forms.Panel();
			this.Serviceslabel = new System.Windows.Forms.Label();
			this.accInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// accInfoPanel
			// 
			this.accInfoPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.accInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.accInfoPanel.Controls.Add(this.nameLabel);
			this.accInfoPanel.Controls.Add(this.buttonLogout);
			this.accInfoPanel.Controls.Add(this.emailLabel);
			this.accInfoPanel.Location = new System.Drawing.Point(12, 52);
			this.accInfoPanel.Name = "accInfoPanel";
			this.accInfoPanel.Size = new System.Drawing.Size(188, 185);
			this.accInfoPanel.TabIndex = 8;
			this.accInfoPanel.Visible = false;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(16, 10);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(57, 13);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "UserName";
			// 
			// buttonLogout
			// 
			this.buttonLogout.Location = new System.Drawing.Point(19, 124);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(92, 29);
			this.buttonLogout.TabIndex = 3;
			this.buttonLogout.Text = "Выйти";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(16, 45);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(54, 13);
			this.emailLabel.TabIndex = 1;
			this.emailLabel.Text = "UserEmail";
			// 
			// buttonAccountInfo
			// 
			this.buttonAccountInfo.Location = new System.Drawing.Point(12, 12);
			this.buttonAccountInfo.Name = "buttonAccountInfo";
			this.buttonAccountInfo.Size = new System.Drawing.Size(70, 35);
			this.buttonAccountInfo.TabIndex = 9;
			this.buttonAccountInfo.Text = "Профиль";
			this.buttonAccountInfo.UseVisualStyleBackColor = true;
			this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
			// 
			// servicesPanel
			// 
			this.servicesPanel.AutoScroll = true;
			this.servicesPanel.Location = new System.Drawing.Point(460, 63);
			this.servicesPanel.Name = "servicesPanel";
			this.servicesPanel.Size = new System.Drawing.Size(318, 540);
			this.servicesPanel.TabIndex = 10;
			// 
			// Serviceslabel
			// 
			this.Serviceslabel.AutoSize = true;
			this.Serviceslabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Serviceslabel.Location = new System.Drawing.Point(556, 12);
			this.Serviceslabel.Name = "Serviceslabel";
			this.Serviceslabel.Size = new System.Drawing.Size(109, 36);
			this.Serviceslabel.TabIndex = 11;
			this.Serviceslabel.Text = "Услуги";
			// 
			// ServicesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.Serviceslabel);
			this.Controls.Add(this.servicesPanel);
			this.Controls.Add(this.accInfoPanel);
			this.Controls.Add(this.buttonAccountInfo);
			this.Name = "ServicesForm";
			this.Text = "ServicesForm";
			this.accInfoPanel.ResumeLayout(false);
			this.accInfoPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel accInfoPanel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button buttonAccountInfo;
		private System.Windows.Forms.Panel servicesPanel;
		private System.Windows.Forms.Label Serviceslabel;
	}
}