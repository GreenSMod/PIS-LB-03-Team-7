namespace MigrationRoadmap.Forms
{
	partial class ServiceInfoForm
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
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonReturn
			// 
			this.buttonReturn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonReturn.Location = new System.Drawing.Point(30, 30);
			this.buttonReturn.Name = "buttonReturn";
			this.buttonReturn.Size = new System.Drawing.Size(150, 40);
			this.buttonReturn.TabIndex = 4;
			this.buttonReturn.Text = "Назад";
			this.buttonReturn.UseVisualStyleBackColor = true;
			this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
			// 
			// serviceTypeLabel
			// 
			this.serviceTypeLabel.AutoSize = true;
			this.serviceTypeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.serviceTypeLabel.Location = new System.Drawing.Point(26, 110);
			this.serviceTypeLabel.MaximumSize = new System.Drawing.Size(400, 0);
			this.serviceTypeLabel.Name = "serviceTypeLabel";
			this.serviceTypeLabel.Size = new System.Drawing.Size(141, 21);
			this.serviceTypeLabel.TabIndex = 5;
			this.serviceTypeLabel.Text = "serviceTypeLabel";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.descriptionLabel.Location = new System.Drawing.Point(26, 194);
			this.descriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(134, 21);
			this.descriptionLabel.TabIndex = 6;
			this.descriptionLabel.Text = "descriptionLabel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 347);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(25, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 27);
			this.label2.TabIndex = 8;
			this.label2.Text = "Срок:";
			// 
			// ServiceInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.serviceTypeLabel);
			this.Controls.Add(this.buttonReturn);
			this.Name = "ServiceInfoForm";
			this.Text = "ServiceInfoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonReturn;
		private System.Windows.Forms.Label serviceTypeLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}