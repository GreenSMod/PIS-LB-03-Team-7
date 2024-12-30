using System.Windows.Forms;

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
			this.nameLabel = new System.Windows.Forms.Label();
			this.passportLabel = new System.Windows.Forms.Label();
			this.buttonReturn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailField
			// 
			this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
			this.emailField.Location = new System.Drawing.Point(80, 80);
			this.emailField.Name = "emailField";
			this.emailField.Size = new System.Drawing.Size(400, 49);
			this.emailField.TabIndex = 0;
			// 
			// passField
			// 
			this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
			this.passField.Location = new System.Drawing.Point(80, 370);
			this.passField.Name = "passField";
			this.passField.Size = new System.Drawing.Size(400, 49);
			this.passField.TabIndex = 1;
			// 
			// buttonUpdateAccount
			// 
			this.buttonUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
			this.buttonUpdateAccount.Location = new System.Drawing.Point(80, 520);
			this.buttonUpdateAccount.Name = "buttonUpdateAccount";
			this.buttonUpdateAccount.Size = new System.Drawing.Size(221, 50);
			this.buttonUpdateAccount.TabIndex = 2;
			this.buttonUpdateAccount.Text = "Сохранить";
			this.buttonUpdateAccount.UseVisualStyleBackColor = true;
			this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonReturn_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.nameLabel.Location = new System.Drawing.Point(80, 170);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(147, 31);
			this.nameLabel.TabIndex = 3;
			this.nameLabel.Text = "nameLabel";
			// 
			// passportLabel
			// 
			this.passportLabel.AutoSize = true;
			this.passportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.passportLabel.ForeColor = System.Drawing.SystemColors.GrayText;
			this.passportLabel.Location = new System.Drawing.Point(80, 240);
			this.passportLabel.Name = "passportLabel";
			this.passportLabel.Size = new System.Drawing.Size(148, 25);
			this.passportLabel.TabIndex = 4;
			this.passportLabel.Text = "passportLabel";
			// 
			// buttonReturn
			// 
			this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonReturn.Location = new System.Drawing.Point(361, 520);
			this.buttonReturn.Name = "buttonReturn";
			this.buttonReturn.Size = new System.Drawing.Size(200, 50);
			this.buttonReturn.TabIndex = 5;
			this.buttonReturn.Text = "Назад";
			this.buttonReturn.UseVisualStyleBackColor = true;
			this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.buttonReturn);
			this.Controls.Add(this.passportLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.buttonUpdateAccount);
			this.Controls.Add(this.passField);
			this.Controls.Add(this.emailField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AccountForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "РЕДАКТИРОВАНИЕ ПРОФИЛЯ";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private void ReinitializeComponent()
        {
            this.FormClosing += AccountForm_FormClosing;
            Program.SendMessage(this.emailField.Handle, 0x1501, 0, "Email");
            Program.SendMessage(this.passField.Handle, 0x1501, 0, "Пароль");
            this.buttonReturn.Select();
            this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdateAccount_Click);
        }

        void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Context.MainForm.Close();
        }

        private System.Windows.Forms.TextBox emailField;
		private System.Windows.Forms.TextBox passField;
		private System.Windows.Forms.Button buttonUpdateAccount;
        private Label nameLabel;
        private Label passportLabel;
        private Button buttonReturn;
    }
}