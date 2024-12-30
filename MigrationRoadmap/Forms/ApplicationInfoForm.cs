﻿using MigrationRoadmap.Models;
using MigrationRoadmap.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace MigrationRoadmap.Forms
{
	public partial class ApplicationInfoForm : Form
	{
		private MigrationSpecialistViewModel migrationSpecialistViewModel;
		private ApplicationModel application;

		public ApplicationInfoForm()
		{
			InitializeComponent();
            //ReinitializeComponent();
        }

        public ApplicationInfoForm(ApplicationModel application)
        {
            InitializeComponent();
            this.Text = "ЗАЯВКА #" + application.Id.ToString();
			//repatriateViewModel = new RepatriateViewModel(user);
			serviceTypeLabel.Text = application.ServiceType.ToString();
			statusLabel.Text = application.ApplicationStatus.ToString();
			translateForUser();
			showDocuments(application);
		}

		public ApplicationInfoForm(ApplicationModel application, MigrationSpecialistViewModel viewModel) : this(application)
		{
			migrationSpecialistViewModel = viewModel;
			this.application = application;
			updatePermissions();
		}

		private void buttonReturn_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm.Location = this.Location;
            Program.Context.MainForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Hide();
            //this.Close();
        }

		private void updatePermissions()
		{
			buttonApprove.Enabled = true;
			buttonApprove.Visible = true;
			buttonReject.Enabled = true;
			buttonReject.Visible = true;
			reasonLabel.Visible = true;
			reasonField.Visible = true;
		}

		private void translateForUser()
		{
			string st = "";

			switch (serviceTypeLabel.Text)
			{
				case "RelocationProgram":
					st = "на запись для постановки на учёт в качестве участника Государственной программы переселения соотечественников";
					break;
				case "CompensationExpenses":
					st = "на компенсацию расходов по найму жилья";
					break;
			}

			serviceTypeLabel.Text = $"Заявка {st}";

			string s = "";

			switch (statusLabel.Text)
			{
				case "UnderConsideration":
					s = "НА РАССМОТРЕНИИ";
					break;
				case "Approved":
					s = "ОДОБРЕНО";
					break;
				case "Rejected":
					s = "ОТКЛОНЕНО";
					break;
			}

			statusLabel.Text = $"Статус: {s}";
		}

		private void showDocuments(ApplicationModel application)
		{
			
			var documents = application.Documents;

			if (documents != null)
				foreach (var document in documents.OrderByDescending(doc => doc.Id))
				{
					string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\MigrationRoadmap\Data\{document.Link}");

					var pictureBox = new PictureBox
					{
						SizeMode = PictureBoxSizeMode.Zoom,
						Image = Image.FromFile(path),
						Width = 500,
						Height = 500,
						Dock = DockStyle.Top,
					};

					docsPanel.Controls.Add(pictureBox);
				}
		}

		private void buttonApprove_Click(object sender, EventArgs e)
		{
			migrationSpecialistViewModel.ApproveApplication(application.Id);
		}

		private void buttonReject_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(reasonField.Text))
			{
				MessageBox.Show("Пожалуйста, укажите причину отклонения");
			}
			else
			{
				migrationSpecialistViewModel.RejectApplication(application.Id, reasonField.Text);
			}
		}
	}
}