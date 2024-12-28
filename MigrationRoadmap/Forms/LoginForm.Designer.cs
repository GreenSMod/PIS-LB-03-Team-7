namespace MigrationRoadmap
{
	partial class LoginForm
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailField
			// 
			this.emailField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emailField.Location = new System.Drawing.Point(54, 89);
			this.emailField.Name = "emailField";
			this.emailField.Size = new System.Drawing.Size(219, 50);
			this.emailField.TabIndex = 0;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passField.Location = new System.Drawing.Point(54, 180);
			this.passField.Name = "passField";
			this.passField.Size = new System.Drawing.Size(219, 50);
			this.passField.TabIndex = 1;
			this.passField.UseSystemPasswordChar = true;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonLogin.Location = new System.Drawing.Point(89, 301);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(149, 42);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 450);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.passField);
			this.Controls.Add(this.emailField);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailField;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.Button buttonLogin;
	}
}