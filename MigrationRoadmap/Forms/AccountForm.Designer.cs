namespace MigrationRoadmap.Forms
{
	partial class AccountForm
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
			this.emailField = new System.Windows.Forms.TextBox();
			this.passField = new System.Windows.Forms.TextBox();
			this.buttonUpdateAccount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailField
			// 
			this.emailField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emailField.Location = new System.Drawing.Point(79, 79);
			this.emailField.Name = "emailField";
			this.emailField.Size = new System.Drawing.Size(195, 50);
			this.emailField.TabIndex = 0;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passField.Location = new System.Drawing.Point(79, 171);
			this.passField.Name = "passField";
			this.passField.Size = new System.Drawing.Size(195, 50);
			this.passField.TabIndex = 1;
			// 
			// buttonUpdateAccount
			// 
			this.buttonUpdateAccount.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpdateAccount.Location = new System.Drawing.Point(79, 267);
			this.buttonUpdateAccount.Name = "buttonUpdateAccount";
			this.buttonUpdateAccount.Size = new System.Drawing.Size(195, 52);
			this.buttonUpdateAccount.TabIndex = 2;
			this.buttonUpdateAccount.Text = "Изменить";
			this.buttonUpdateAccount.UseVisualStyleBackColor = true;
			this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdateAccount_Click_1);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 450);
			this.Controls.Add(this.buttonUpdateAccount);
			this.Controls.Add(this.passField);
			this.Controls.Add(this.emailField);
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailField;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.Button buttonUpdateAccount;
	}
}