﻿namespace MigrationRoadmap.Forms
{
	partial class MigrationSpecialistConsiderForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.activeApplications = new System.Windows.Forms.TabPage();
			this.archiveApplications = new System.Windows.Forms.TabPage();
			this.buttonAccountInfo = new System.Windows.Forms.Button();
			this.accInfoPanel = new System.Windows.Forms.Panel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.emailLabel = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.accInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.activeApplications);
			this.tabControl1.Controls.Add(this.archiveApplications);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.TabIndex = 5;
            this.tabControl1.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(15, 130);
            this.tabControl1.Size = new System.Drawing.Size(950, 600);
            // 
            // activeApplications
            // 
            this.activeApplications.AutoScroll = true;
			this.activeApplications.Name = "activeApplications";
			this.activeApplications.Padding = new System.Windows.Forms.Padding(3);
			this.activeApplications.TabIndex = 0;
			this.activeApplications.Text = "Активные заявки";
			this.activeApplications.UseVisualStyleBackColor = true;
            this.activeApplications.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeApplications.Location = new System.Drawing.Point(4, 39);
            this.activeApplications.Size = new System.Drawing.Size(942, 557);
            // 
            // archiveApplications
            // 
            this.archiveApplications.AutoScroll = true;
			this.archiveApplications.Name = "archiveApplications";
			this.archiveApplications.Padding = new System.Windows.Forms.Padding(3);
			this.archiveApplications.TabIndex = 1;
			this.archiveApplications.Text = "Архивные заявки";
			this.archiveApplications.UseVisualStyleBackColor = true;
            this.archiveApplications.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveApplications.Location = new System.Drawing.Point(4, 39);
            this.archiveApplications.Size = new System.Drawing.Size(942, 557);
            // 
            // buttonAccountInfo
            // 
			this.buttonAccountInfo.Name = "buttonAccountInfo";
			this.buttonAccountInfo.TabIndex = 7;
			this.buttonAccountInfo.Text = "Профиль";
			this.buttonAccountInfo.UseVisualStyleBackColor = true;
			this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
            this.buttonAccountInfo.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccountInfo.Location = new System.Drawing.Point(15, 15);
            this.buttonAccountInfo.Size = new System.Drawing.Size(100, 35);
            // 
            // accInfoPanel
            // 
            this.accInfoPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.accInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.accInfoPanel.Controls.Add(this.nameLabel);
			this.accInfoPanel.Controls.Add(this.buttonLogout);
			this.accInfoPanel.Controls.Add(this.emailLabel);
			this.accInfoPanel.Location = new System.Drawing.Point(15, 55);
			this.accInfoPanel.Name = "accInfoPanel";
			this.accInfoPanel.Size = new System.Drawing.Size(188, 185);
			this.accInfoPanel.TabIndex = 6;
			this.accInfoPanel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 10);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "UserName";
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Size = new System.Drawing.Size(150, 35);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(19, 142);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(92, 29);
			this.buttonLogout.TabIndex = 3;
			this.buttonLogout.Text = "Выйти";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(92, 29);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.emailLabel.Location = new System.Drawing.Point(16, 45);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(150, 15);
			this.emailLabel.TabIndex = 1;
			this.emailLabel.Text = "UserEmail";
            this.emailLabel.Font = new System.Drawing.Font("Liberation Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // MigrationSpecialistConsiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.buttonAccountInfo);
			this.Controls.Add(this.accInfoPanel);
			this.Controls.Add(this.tabControl1);
			this.Name = "MigrationSpecialistConsiderForm";
			this.Text = "ГЛАВНАЯ";
			this.tabControl1.ResumeLayout(false);
			this.accInfoPanel.ResumeLayout(false);
			this.accInfoPanel.PerformLayout();
			this.ResumeLayout(false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

        }

        #endregion

        private void ReinitializeComponent()
        {
            this.accInfoPanel.BringToFront();

        }

        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage activeApplications;
		private System.Windows.Forms.TabPage archiveApplications;
		private System.Windows.Forms.Button buttonAccountInfo;
		private System.Windows.Forms.Panel accInfoPanel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label emailLabel;
	}
}