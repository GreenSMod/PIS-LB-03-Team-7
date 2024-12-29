using MigrationRoadmap.Models;
using MigrationRoadmap.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MigrationRoadmap.Forms
{
	public partial class RepatriateMainForm : Form
	{
		private RepatriateViewModel repatriateViewModel;

		public RepatriateMainForm(UserModel user)
		{
			InitializeComponent();
			repatriateViewModel = new RepatriateViewModel(user);
			emailLabel.Text = user.Email;
			CreateDynamicButtons();
		}

		private void buttonApplyApplicationRelocation_Click(object sender, EventArgs e)
		{
			repatriateViewModel.ApplyApplication(ServiceType.RelocationProgram);
		}

		private void buttonApplyApplicationCompensation_Click(object sender, EventArgs e)
		{
			repatriateViewModel.ApplyApplication(ServiceType.CompensationExpenses);
		}

		private void buttonAccountInfo_Click(object sender, EventArgs e)
		{
			accInfoPanel.Visible = !accInfoPanel.Visible;
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			var loginForm = new LoginForm();
			loginForm.Show();
		}

		private void buttonChangeAccInfo_Click(object sender, EventArgs e)
		{
			this.Hide();
			var loginForm = new AccountForm(repatriateViewModel.Repatriate);
			loginForm.Show();
		}



		private void CreateDynamicButtons()
		{
			var applications = repatriateViewModel.Repatriate.Applications;

			if (applications != null)
			{
				applications = applications.Where(app => app.ApplicationStatus == ApplicationStatus.UnderConsideration).ToList();

				foreach (var application in applications)
				{
					Button button = new Button();
					button.Text = Text = $"Заявка #{application.Id} ({application.ServiceType})";
					button.Dock = DockStyle.Top;
					button.Height = 40;
					button.Click += buttonApllication_Click;

					this.Controls.Add(button);
					activeApplications.Controls.Add(button);
				}
			}
		}

		private void buttonApllication_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (button != null)
			{
				var applicationInfoForm = new ApplicationIfnoForm();
				applicationInfoForm.Show();
			}
		}
	}
}
