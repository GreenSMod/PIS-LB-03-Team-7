using System.Diagnostics;
using System.Windows.Forms;

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
            this.buttonApplications = new System.Windows.Forms.Button();
            this.accInfoPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonChangeAccInfo = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.activeApplications = new System.Windows.Forms.TabPage();
            this.archiveApplications = new System.Windows.Forms.TabPage();
            this.applicationInfoPanel = new System.Windows.Forms.Panel();
            this.docsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelApplications = new System.Windows.Forms.Panel();
            this.buttonApplication2 = new System.Windows.Forms.Button();
            this.buttonApplication1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accInfoPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.applicationInfoPanel.SuspendLayout();
            this.panelApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApplications
            // 
            this.buttonApplications.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplications.Location = new System.Drawing.Point(260, 15);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Size = new System.Drawing.Size(182, 43);
            this.buttonApplications.TabIndex = 0;
            this.buttonApplications.Text = "Подать заявку";
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.buttonApplications_Click);
            // 
            // accInfoPanel
            // 
            this.accInfoPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accInfoPanel.Controls.Add(this.nameLabel);
            this.accInfoPanel.Controls.Add(this.buttonLogout);
            this.accInfoPanel.Controls.Add(this.buttonChangeAccInfo);
            this.accInfoPanel.Controls.Add(this.emailLabel);
            this.accInfoPanel.Location = new System.Drawing.Point(15, 55);
            this.accInfoPanel.Name = "accInfoPanel";
            this.accInfoPanel.Size = new System.Drawing.Size(188, 185);
            this.accInfoPanel.TabIndex = 2;
            this.accInfoPanel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(16, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(150, 35);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "UserName";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(19, 142);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(71, 29);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Выйти";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonChangeAccInfo
            // 
            this.buttonChangeAccInfo.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeAccInfo.Location = new System.Drawing.Point(19, 76);
            this.buttonChangeAccInfo.Name = "buttonChangeAccInfo";
            this.buttonChangeAccInfo.Size = new System.Drawing.Size(147, 29);
            this.buttonChangeAccInfo.TabIndex = 2;
            this.buttonChangeAccInfo.Text = "Редактировать";
            this.buttonChangeAccInfo.UseVisualStyleBackColor = true;
            this.buttonChangeAccInfo.Click += new System.EventHandler(this.buttonChangeAccInfo_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.emailLabel.Font = new System.Drawing.Font("Liberation Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailLabel.Location = new System.Drawing.Point(16, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(150, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "UserEmail";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.activeApplications);
            this.tabControl1.Controls.Add(this.archiveApplications);
            this.tabControl1.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(15, 130);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 600);
            this.tabControl1.TabIndex = 4;
            // 
            // activeApplications
            // 
            this.activeApplications.AutoScroll = true;
            this.activeApplications.Font = new System.Drawing.Font("Liberation Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeApplications.Location = new System.Drawing.Point(4, 39);
            this.activeApplications.Name = "activeApplications";
            this.activeApplications.Padding = new System.Windows.Forms.Padding(3);
            this.activeApplications.Size = new System.Drawing.Size(942, 557);
            this.activeApplications.TabIndex = 0;
            this.activeApplications.Text = "Активные заявки";
            this.activeApplications.UseVisualStyleBackColor = true;
            this.activeApplications.Click += new System.EventHandler(this.activeApplications_Click);
            // 
            // archiveApplications
            // 
            this.archiveApplications.AutoScroll = true;
            this.archiveApplications.Location = new System.Drawing.Point(4, 39);
            this.archiveApplications.Name = "archiveApplications";
            this.archiveApplications.Padding = new System.Windows.Forms.Padding(3);
            this.archiveApplications.Size = new System.Drawing.Size(942, 551);
            this.archiveApplications.TabIndex = 1;
            this.archiveApplications.Text = "Архивные заявки";
            this.archiveApplications.UseVisualStyleBackColor = true;
            // 
            // applicationInfoPanel
            // 
            this.applicationInfoPanel.Controls.Add(this.docsPanel);
            this.applicationInfoPanel.Controls.Add(this.label1);
            this.applicationInfoPanel.Controls.Add(this.label3);
            this.applicationInfoPanel.Controls.Add(this.label2);
            this.applicationInfoPanel.Location = new System.Drawing.Point(459, 141);
            this.applicationInfoPanel.Name = "applicationInfoPanel";
            this.applicationInfoPanel.Size = new System.Drawing.Size(501, 479);
            this.applicationInfoPanel.TabIndex = 0;
            this.applicationInfoPanel.Visible = false;
            // 
            // docsPanel
            // 
            this.docsPanel.AutoScroll = true;
            this.docsPanel.Location = new System.Drawing.Point(12, 156);
            this.docsPanel.Name = "docsPanel";
            this.docsPanel.Size = new System.Drawing.Size(348, 293);
            this.docsPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Документы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Статус: На рассмотрении";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заявка подана";
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccountInfo.Location = new System.Drawing.Point(15, 15);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(100, 35);
            this.buttonAccountInfo.TabIndex = 3;
            this.buttonAccountInfo.Text = "Профиль";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
            // 
            // panelApplications
            // 
            this.panelApplications.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelApplications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApplications.Controls.Add(this.buttonApplication2);
            this.panelApplications.Controls.Add(this.buttonApplication1);
            this.panelApplications.Location = new System.Drawing.Point(460, 15);
            this.panelApplications.Name = "panelApplications";
            this.panelApplications.Size = new System.Drawing.Size(500, 130);
            this.panelApplications.TabIndex = 6;
            this.panelApplications.Visible = false;
            // 
            // buttonApplication2
            // 
            this.buttonApplication2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonApplication2.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplication2.Location = new System.Drawing.Point(10, 70);
            this.buttonApplication2.Name = "buttonApplication2";
            this.buttonApplication2.Size = new System.Drawing.Size(480, 50);
            this.buttonApplication2.TabIndex = 1;
            this.buttonApplication2.Text = "Компенсация расходов по найму жилья";
            this.buttonApplication2.UseVisualStyleBackColor = true;
            this.buttonApplication2.Click += new System.EventHandler(this.buttonApplication2_Click);
            // 
            // buttonApplication1
            // 
            this.buttonApplication1.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplication1.Location = new System.Drawing.Point(10, 10);
            this.buttonApplication1.Name = "buttonApplication1";
            this.buttonApplication1.Size = new System.Drawing.Size(480, 50);
            this.buttonApplication1.TabIndex = 0;
            this.buttonApplication1.Text = "Постановка на учёт в качестве участника Государственной программы переселения соо" +
    "течественников";
            this.buttonApplication1.UseVisualStyleBackColor = true;
            this.buttonApplication1.Click += new System.EventHandler(this.buttonApplication1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 608);
            this.panel1.TabIndex = 7;
            // 
            // RepatriateMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.applicationInfoPanel);
            this.Controls.Add(this.panelApplications);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.buttonApplications);
            this.Controls.Add(this.accInfoPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RepatriateMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ГЛАВНАЯ";
            this.accInfoPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.applicationInfoPanel.ResumeLayout(false);
            this.applicationInfoPanel.PerformLayout();
            this.panelApplications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void ReinitializeComponent()
		{
            this.accInfoPanel.BringToFront();
            this.panel1.BringToFront();
        }

        private System.Windows.Forms.Button buttonApplications;
		private System.Windows.Forms.Panel accInfoPanel;
		private System.Windows.Forms.Button buttonAccountInfo;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Button buttonChangeAccInfo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage activeApplications;
        private System.Windows.Forms.TabPage archiveApplications;
        private System.Windows.Forms.Panel panelApplications;
        private System.Windows.Forms.Button buttonApplication2;
        private System.Windows.Forms.Button buttonApplication1;
		private OpenFileDialog openFileDialog;
		private Panel applicationInfoPanel;
		private Panel docsPanel;
		private Label label1;
		private Label label3;
		private Label label2;
        private Panel panel1;
    }
}