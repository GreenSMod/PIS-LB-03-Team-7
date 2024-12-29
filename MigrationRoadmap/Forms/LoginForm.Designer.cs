using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.emailField.Location = new System.Drawing.Point(54, 245);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(400, 50);
            this.emailField.TabIndex = 0;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(54, 334);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(400, 50);
            this.passField.TabIndex = 1;
            this.passField.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(54, 504);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 40);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.buttonLogin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АВТОРИЗАЦИЯ";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private void ReinitializeComponent()
        {
            this.emailField.Location = new Point()
            {
                X = (this.Width - this.emailField.Width) / 2,
                Y = emailField.Location.Y
            };
            Program.SendMessage(this.emailField.Handle, 0x1501, 0, "Email");
            

            this.passField.Location = new Point()
            {
                X = (this.Width - this.passField.Width) / 2,
                Y = this.passField.Location.Y
            };
            Program.SendMessage(this.passField.Handle, 0x1501, 0, "Пароль");

            this.buttonLogin.Location = new Point()
            {
                X = (this.Width - this.buttonLogin.Width) / 2,
                Y = this.buttonLogin.Location.Y
            };
            this.buttonLogin.Select();
        }

		private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button buttonLogin;
    }
}