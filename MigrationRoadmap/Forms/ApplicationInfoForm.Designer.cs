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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.statusLabel.Font = new System.Drawing.Font("Liberation Serif", 24F);
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
            this.DocsLabel.Font = new System.Drawing.Font("Liberation Serif", 24F);
            this.DocsLabel.Location = new System.Drawing.Point(650, 34);
            this.DocsLabel.Name = "DocsLabel";
            this.DocsLabel.Size = new System.Drawing.Size(171, 36);
            this.DocsLabel.TabIndex = 7;
            this.DocsLabel.Text = "Документы";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Liberation Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(30, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Liberation Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(30, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ApplicationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void ApplicationInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Context.MainForm.Close();
        }

        #endregion

        private Button buttonReturn;
		private Label serviceTypeLabel;
		private Label statusLabel;
		private Panel docsPanel;
		private Label DocsLabel;
		private Button button1;
		private Button button2;
	}
}