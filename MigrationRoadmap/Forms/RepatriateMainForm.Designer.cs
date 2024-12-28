namespace MigrationRoadmap.Forms
{
	partial class RepatriateMainForm
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
			this.buttonApplyApplicationRelocation = new System.Windows.Forms.Button();
			this.buttonApplyApplicationCompensation = new System.Windows.Forms.Button();
			this.accInfoPanel = new System.Windows.Forms.Panel();
			this.emailLabel = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.buttonAccountInfo = new System.Windows.Forms.Button();
			this.buttonChangeAccInfo = new System.Windows.Forms.Button();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.accInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonApplyApplicationRelocation
			// 
			this.buttonApplyApplicationRelocation.Location = new System.Drawing.Point(64, 70);
			this.buttonApplyApplicationRelocation.Name = "buttonApplyApplicationRelocation";
			this.buttonApplyApplicationRelocation.Size = new System.Drawing.Size(166, 43);
			this.buttonApplyApplicationRelocation.TabIndex = 0;
			this.buttonApplyApplicationRelocation.Text = "Подать";
			this.buttonApplyApplicationRelocation.UseVisualStyleBackColor = true;
			this.buttonApplyApplicationRelocation.Click += new System.EventHandler(this.buttonApplyApplicationRelocation_Click);
			// 
			// buttonApplyApplicationCompensation
			// 
			this.buttonApplyApplicationCompensation.Location = new System.Drawing.Point(64, 152);
			this.buttonApplyApplicationCompensation.Name = "buttonApplyApplicationCompensation";
			this.buttonApplyApplicationCompensation.Size = new System.Drawing.Size(166, 43);
			this.buttonApplyApplicationCompensation.TabIndex = 1;
			this.buttonApplyApplicationCompensation.Text = "Подать";
			this.buttonApplyApplicationCompensation.UseVisualStyleBackColor = true;
			this.buttonApplyApplicationCompensation.Click += new System.EventHandler(this.buttonApplyApplicationCompensation_Click);
			// 
			// accInfoPanel
			// 
			this.accInfoPanel.Controls.Add(this.buttonLogout);
			this.accInfoPanel.Controls.Add(this.buttonChangeAccInfo);
			this.accInfoPanel.Controls.Add(this.emailLabel);
			this.accInfoPanel.Controls.Add(this.Email);
			this.accInfoPanel.Location = new System.Drawing.Point(25, 252);
			this.accInfoPanel.Name = "accInfoPanel";
			this.accInfoPanel.Size = new System.Drawing.Size(254, 118);
			this.accInfoPanel.TabIndex = 2;
			this.accInfoPanel.Visible = false;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(54, 12);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(54, 13);
			this.emailLabel.TabIndex = 1;
			this.emailLabel.Text = "UserEmail";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(16, 12);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(32, 13);
			this.Email.TabIndex = 0;
			this.Email.Text = "Email";
			// 
			// buttonAccountInfo
			// 
			this.buttonAccountInfo.Location = new System.Drawing.Point(86, 403);
			this.buttonAccountInfo.Name = "buttonAccountInfo";
			this.buttonAccountInfo.Size = new System.Drawing.Size(127, 35);
			this.buttonAccountInfo.TabIndex = 3;
			this.buttonAccountInfo.Text = "Аккаунт";
			this.buttonAccountInfo.UseVisualStyleBackColor = true;
			this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
			// 
			// buttonChangeAccInfo
			// 
			this.buttonChangeAccInfo.Location = new System.Drawing.Point(19, 63);
			this.buttonChangeAccInfo.Name = "buttonChangeAccInfo";
			this.buttonChangeAccInfo.Size = new System.Drawing.Size(92, 29);
			this.buttonChangeAccInfo.TabIndex = 2;
			this.buttonChangeAccInfo.Text = "Изменить";
			this.buttonChangeAccInfo.UseVisualStyleBackColor = true;
			this.buttonChangeAccInfo.Click += new System.EventHandler(this.buttonChangeAccInfo_Click);
			// 
			// buttonLogout
			// 
			this.buttonLogout.Location = new System.Drawing.Point(138, 63);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(92, 29);
			this.buttonLogout.TabIndex = 3;
			this.buttonLogout.Text = "Выйти";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// RepatriateMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 450);
			this.Controls.Add(this.buttonAccountInfo);
			this.Controls.Add(this.accInfoPanel);
			this.Controls.Add(this.buttonApplyApplicationCompensation);
			this.Controls.Add(this.buttonApplyApplicationRelocation);
			this.Name = "RepatriateMainForm";
			this.Text = "RepatriateMainForm";
			this.accInfoPanel.ResumeLayout(false);
			this.accInfoPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonApplyApplicationRelocation;
		private System.Windows.Forms.Button buttonApplyApplicationCompensation;
		private System.Windows.Forms.Panel accInfoPanel;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Button buttonAccountInfo;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Button buttonChangeAccInfo;
	}
}