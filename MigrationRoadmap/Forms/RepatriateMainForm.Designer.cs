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
			this.buttonApplyApplicationRelocation = new System.Windows.Forms.Button();
			this.buttonApplyApplicationCompensation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonApplyApplicationRelocation
			// 
			this.buttonApplyApplicationRelocation.Location = new System.Drawing.Point(64, 70);
			this.buttonApplyApplicationRelocation.Name = "buttonApplyApplicationRelocation";
			this.buttonApplyApplicationRelocation.Size = new System.Drawing.Size(166, 43);
			this.buttonApplyApplicationRelocation.TabIndex = 0;
			this.buttonApplyApplicationRelocation.Text = "Подать";
			this.buttonApplyApplicationRelocation.UseVisualStyleBackColor = true;
			// 
			// buttonApplyApplicationCompensation
			// 
			this.buttonApplyApplicationCompensation.Location = new System.Drawing.Point(64, 152);
			this.buttonApplyApplicationCompensation.Name = "buttonApplyApplicationCompensation";
			this.buttonApplyApplicationCompensation.Size = new System.Drawing.Size(166, 43);
			this.buttonApplyApplicationCompensation.TabIndex = 1;
			this.buttonApplyApplicationCompensation.Text = "Подать";
			this.buttonApplyApplicationCompensation.UseVisualStyleBackColor = true;
			// 
			// RepatriateMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 450);
			this.Controls.Add(this.buttonApplyApplicationCompensation);
			this.Controls.Add(this.buttonApplyApplicationRelocation);
			this.Name = "RepatriateMainForm";
			this.Text = "RepatriateMainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonApplyApplicationRelocation;
		private System.Windows.Forms.Button buttonApplyApplicationCompensation;
	}
}