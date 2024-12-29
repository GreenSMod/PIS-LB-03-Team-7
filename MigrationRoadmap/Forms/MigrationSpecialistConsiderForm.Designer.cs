namespace MigrationRoadmap.Forms
{
	partial class MigrationSpecialistConsiderForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.activeApplications = new System.Windows.Forms.TabPage();
			this.archiveApplications = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.activeApplications);
			this.tabControl1.Controls.Add(this.archiveApplications);
			this.tabControl1.Location = new System.Drawing.Point(313, 41);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(545, 493);
			this.tabControl1.TabIndex = 5;
			// 
			// activeApplications
			// 
			this.activeApplications.AutoScroll = true;
			this.activeApplications.Location = new System.Drawing.Point(4, 22);
			this.activeApplications.Name = "activeApplications";
			this.activeApplications.Padding = new System.Windows.Forms.Padding(3);
			this.activeApplications.Size = new System.Drawing.Size(537, 467);
			this.activeApplications.TabIndex = 0;
			this.activeApplications.Text = "Активные заявки";
			this.activeApplications.UseVisualStyleBackColor = true;
			// 
			// archiveApplications
			// 
			this.archiveApplications.AutoScroll = true;
			this.archiveApplications.Location = new System.Drawing.Point(4, 22);
			this.archiveApplications.Name = "archiveApplications";
			this.archiveApplications.Padding = new System.Windows.Forms.Padding(3);
			this.archiveApplications.Size = new System.Drawing.Size(537, 467);
			this.archiveApplications.TabIndex = 1;
			this.archiveApplications.Text = "Архивные заявки";
			this.archiveApplications.UseVisualStyleBackColor = true;
			// 
			// MigrationSpecialistConsiderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 671);
			this.Controls.Add(this.tabControl1);
			this.Name = "MigrationSpecialistConsiderForm";
			this.Text = "MigrationSpecialistConsiderForm";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage activeApplications;
		private System.Windows.Forms.TabPage archiveApplications;
	}
}