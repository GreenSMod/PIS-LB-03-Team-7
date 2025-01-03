﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MigrationRoadmap.Forms
{
	partial class ApplicationInfoForm
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.serviceTypeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.docsPanel = new System.Windows.Forms.Panel();
            this.DocsLabel = new System.Windows.Forms.Label();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.reasonField = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.rejectionLabel = new System.Windows.Forms.Label();
            this.rejectionReasonLabel = new System.Windows.Forms.Label();
            this.checkedLabel = new System.Windows.Forms.Label();
            this.nameSpecialistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Liberation Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.Location = new System.Drawing.Point(30, 30);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(200, 50);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // serviceTypeLabel
            // 
            this.serviceTypeLabel.AutoSize = true;
            this.serviceTypeLabel.Font = new System.Drawing.Font("Liberation Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceTypeLabel.Location = new System.Drawing.Point(26, 200);
            this.serviceTypeLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.serviceTypeLabel.Name = "serviceTypeLabel";
            this.serviceTypeLabel.Size = new System.Drawing.Size(182, 26);
            this.serviceTypeLabel.TabIndex = 4;
            this.serviceTypeLabel.Text = "serviceTypeLabel";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(25, 106);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(156, 36);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "statusLabel";
            // 
            // docsPanel
            // 
            this.docsPanel.AutoScroll = true;
            this.docsPanel.Location = new System.Drawing.Point(492, 106);
            this.docsPanel.Name = "docsPanel";
            this.docsPanel.Size = new System.Drawing.Size(480, 445);
            this.docsPanel.TabIndex = 6;
            // 
            // DocsLabel
            // 
            this.DocsLabel.AutoSize = true;
            this.DocsLabel.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocsLabel.Location = new System.Drawing.Point(650, 34);
            this.DocsLabel.Name = "DocsLabel";
            this.DocsLabel.Size = new System.Drawing.Size(171, 36);
            this.DocsLabel.TabIndex = 7;
            this.DocsLabel.Text = "Документы";
            // 
            // buttonApprove
            // 
            this.buttonApprove.Enabled = false;
            this.buttonApprove.Font = new System.Drawing.Font("Liberation Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApprove.Location = new System.Drawing.Point(30, 600);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(176, 40);
            this.buttonApprove.TabIndex = 8;
            this.buttonApprove.Text = "Одобрить";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Visible = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Enabled = false;
            this.buttonReject.Font = new System.Drawing.Font("Liberation Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReject.Location = new System.Drawing.Point(30, 680);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(176, 40);
            this.buttonReject.TabIndex = 9;
            this.buttonReject.Text = "Отклонить";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Visible = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // reasonField
            // 
            this.reasonField.Enabled = false;
            this.reasonField.Font = new System.Drawing.Font("Liberation Serif", 14F);
            this.reasonField.Location = new System.Drawing.Point(340, 600);
            this.reasonField.Multiline = true;
            this.reasonField.Name = "reasonField";
            this.reasonField.Size = new System.Drawing.Size(300, 90);
            this.reasonField.TabIndex = 10;
            this.reasonField.Visible = false;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reasonLabel.Location = new System.Drawing.Point(340, 570);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(141, 21);
            this.reasonLabel.TabIndex = 11;
            this.reasonLabel.Text = "Причина отказа:";
            this.reasonLabel.Visible = false;
            // 
            // rejectionLabel
            // 
            this.rejectionLabel.AutoSize = true;
            this.rejectionLabel.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rejectionLabel.Location = new System.Drawing.Point(24, 369);
            this.rejectionLabel.Name = "rejectionLabel";
            this.rejectionLabel.Size = new System.Drawing.Size(239, 36);
            this.rejectionLabel.TabIndex = 12;
            this.rejectionLabel.Text = "Причина отказа:";
            this.rejectionLabel.Visible = false;
            // 
            // rejectionReasonLabel
            // 
            this.rejectionReasonLabel.AutoSize = true;
            this.rejectionReasonLabel.Font = new System.Drawing.Font("Liberation Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rejectionReasonLabel.Location = new System.Drawing.Point(27, 423);
            this.rejectionReasonLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.rejectionReasonLabel.Name = "rejectionReasonLabel";
            this.rejectionReasonLabel.Size = new System.Drawing.Size(222, 26);
            this.rejectionReasonLabel.TabIndex = 13;
            this.rejectionReasonLabel.Text = "rejectionReasonLabel";
            this.rejectionReasonLabel.Visible = false;
            // 
            // checkedLabel
            // 
            this.checkedLabel.AutoSize = true;
            this.checkedLabel.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedLabel.Location = new System.Drawing.Point(24, 604);
            this.checkedLabel.Name = "checkedLabel";
            this.checkedLabel.Size = new System.Drawing.Size(193, 36);
            this.checkedLabel.TabIndex = 14;
            this.checkedLabel.Text = "Проверил(а):";
            this.checkedLabel.Visible = true;
            // 
            // nameSpecialistLabel
            // 
            this.nameSpecialistLabel.AutoSize = true;
            this.nameSpecialistLabel.Font = new System.Drawing.Font("Liberation Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameSpecialistLabel.Location = new System.Drawing.Point(27, 663);
            this.nameSpecialistLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.nameSpecialistLabel.Name = "nameSpecialistLabel";
            this.nameSpecialistLabel.Size = new System.Drawing.Size(210, 27);
            this.nameSpecialistLabel.TabIndex = 15;
            this.nameSpecialistLabel.Text = "nameSpecialistLabel";
            this.nameSpecialistLabel.Visible = true;
            // 
            // ApplicationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.nameSpecialistLabel);
            this.Controls.Add(this.checkedLabel);
            this.Controls.Add(this.rejectionReasonLabel);
            this.Controls.Add(this.rejectionLabel);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.reasonField);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.DocsLabel);
            this.Controls.Add(this.docsPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.serviceTypeLabel);
            this.Controls.Add(this.buttonReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicationInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ЗАЯВКА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ReinitializeComponent()
        {
            this.buttonReturn.Select();
            this.FormClosing += ApplicationInfoForm_FormClosing;
        }

        void ApplicationInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Context.MainForm.Close();
        }

        private Button buttonReturn;
		private Label serviceTypeLabel;
		private Label statusLabel;
		private Panel docsPanel;
		private Label DocsLabel;
		private Button buttonApprove;
		private Button buttonReject;
		private TextBox reasonField;
        private Label reasonLabel;
		private Label rejectionLabel;
		private Label rejectionReasonLabel;
		private Label checkedLabel;
		private Label nameSpecialistLabel;
	}
}