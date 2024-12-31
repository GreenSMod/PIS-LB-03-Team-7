using System.Windows.Forms;

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
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChangeService = new System.Windows.Forms.Button();
            this.buttonChangeRegulation = new System.Windows.Forms.Button();
            this.serviceNameField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.deadlineField = new System.Windows.Forms.TextBox();
            this.buttonSaveServiceChange = new System.Windows.Forms.Button();
            this.buttonSaveRegulationChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.Location = new System.Drawing.Point(30, 30);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(150, 40);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceNameLabel.Location = new System.Drawing.Point(26, 110);
            this.serviceNameLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(146, 21);
            this.serviceNameLabel.TabIndex = 5;
            this.serviceNameLabel.Text = "serviceNameLabel";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(26, 194);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(134, 21);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "descriptionLabel";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadlineLabel.Location = new System.Drawing.Point(26, 544);
            this.deadlineLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(112, 21);
            this.deadlineLabel.TabIndex = 7;
            this.deadlineLabel.Text = "deadlineLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Срок:";
            // 
            // buttonChangeService
            // 
            this.buttonChangeService.Font = new System.Drawing.Font("Liberation Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeService.Location = new System.Drawing.Point(379, 110);
            this.buttonChangeService.Name = "buttonChangeService";
            this.buttonChangeService.Size = new System.Drawing.Size(205, 48);
            this.buttonChangeService.TabIndex = 9;
            this.buttonChangeService.Text = "Изменить услугу";
            this.buttonChangeService.UseVisualStyleBackColor = true;
            this.buttonChangeService.Click += new System.EventHandler(this.buttonChangeService_Click);
            // 
            // buttonChangeRegulation
            // 
            this.buttonChangeRegulation.Font = new System.Drawing.Font("Liberation Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeRegulation.Location = new System.Drawing.Point(379, 453);
            this.buttonChangeRegulation.Name = "buttonChangeRegulation";
            this.buttonChangeRegulation.Size = new System.Drawing.Size(205, 48);
            this.buttonChangeRegulation.TabIndex = 10;
            this.buttonChangeRegulation.Text = "Изменить Регламент";
            this.buttonChangeRegulation.UseVisualStyleBackColor = true;
            this.buttonChangeRegulation.Click += new System.EventHandler(this.buttonChangeRegulation_Click);
            // 
            // serviceNameField
            // 
            this.serviceNameField.Font = new System.Drawing.Font("Liberation Serif", 14F);
            this.serviceNameField.Location = new System.Drawing.Point(684, 110);
            this.serviceNameField.Multiline = true;
            this.serviceNameField.Name = "serviceNameField";
            this.serviceNameField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serviceNameField.Size = new System.Drawing.Size(260, 48);
            this.serviceNameField.TabIndex = 11;
            this.serviceNameField.Visible = false;
            // 
            // descriptionField
            // 
            this.descriptionField.Font = new System.Drawing.Font("Liberation Serif", 14F);
            this.descriptionField.Location = new System.Drawing.Point(684, 194);
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionField.Size = new System.Drawing.Size(260, 144);
            this.descriptionField.TabIndex = 12;
            this.descriptionField.Visible = false;
            // 
            // deadlineField
            // 
            this.deadlineField.Font = new System.Drawing.Font("Liberation Serif", 14F);
            this.deadlineField.Location = new System.Drawing.Point(684, 544);
            this.deadlineField.Multiline = true;
            this.deadlineField.Name = "deadlineField";
            this.deadlineField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deadlineField.Size = new System.Drawing.Size(260, 48);
            this.deadlineField.TabIndex = 13;
            this.deadlineField.Visible = false;
            // 
            // buttonSaveServiceChange
            // 
            this.buttonSaveServiceChange.Font = new System.Drawing.Font("Liberation Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveServiceChange.Location = new System.Drawing.Point(379, 290);
            this.buttonSaveServiceChange.Name = "buttonSaveServiceChange";
            this.buttonSaveServiceChange.Size = new System.Drawing.Size(205, 48);
            this.buttonSaveServiceChange.TabIndex = 14;
            this.buttonSaveServiceChange.Text = "Сохранить";
            this.buttonSaveServiceChange.UseVisualStyleBackColor = true;
            this.buttonSaveServiceChange.Visible = false;
            this.buttonSaveServiceChange.Click += new System.EventHandler(this.buttonSaveServiceChange_Click);
            // 
            // buttonSaveRegulationChange
            // 
            this.buttonSaveRegulationChange.Font = new System.Drawing.Font("Liberation Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRegulationChange.Location = new System.Drawing.Point(379, 544);
            this.buttonSaveRegulationChange.Name = "buttonSaveRegulationChange";
            this.buttonSaveRegulationChange.Size = new System.Drawing.Size(205, 48);
            this.buttonSaveRegulationChange.TabIndex = 15;
            this.buttonSaveRegulationChange.Text = "Сохранить";
            this.buttonSaveRegulationChange.UseVisualStyleBackColor = true;
            this.buttonSaveRegulationChange.Visible = false;
            this.buttonSaveRegulationChange.Click += new System.EventHandler(this.buttonSaveRegulationChange_Click);
            // 
            // ServiceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.buttonSaveRegulationChange);
            this.Controls.Add(this.buttonSaveServiceChange);
            this.Controls.Add(this.deadlineField);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.serviceNameField);
            this.Controls.Add(this.buttonChangeRegulation);
            this.Controls.Add(this.buttonChangeService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.buttonReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "УСЛУГА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ReinitializeComponent()
        {
            this.FormClosing += ServiceInfoForm_FormClosing;
        }

        void ServiceInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Context.MainForm.Close();
        }

        private System.Windows.Forms.Button buttonReturn;
		private System.Windows.Forms.Label serviceNameLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Label deadlineLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonChangeService;
		private System.Windows.Forms.Button buttonChangeRegulation;
		private System.Windows.Forms.TextBox serviceNameField;
		private System.Windows.Forms.TextBox descriptionField;
		private System.Windows.Forms.TextBox deadlineField;
		private System.Windows.Forms.Button buttonSaveServiceChange;
		private System.Windows.Forms.Button buttonSaveRegulationChange;
	}
}