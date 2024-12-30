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
            nameLabel.Text = user.FullName;
            emailLabel.Text = user.Email;
            CreateDynamicButtons(activeApplications, ApplicationStatus.UnderConsideration);
			CreateDynamicButtons(archiveApplications, ApplicationStatus.Approved);
		}

		public void UpdateRepatriate(RepatriateModel repatriate)
		{
			repatriateViewModel.UpdateRepatriate(repatriate);
			this.emailLabel.Text = repatriate.Email;
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
            var loginForm = new LoginForm
            {
                Location = this.Location
            };
            Program.Context.MainForm = loginForm;
            Program.Context.MainForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Close();
        }

		private void buttonChangeAccInfo_Click(object sender, EventArgs e)
		{
            accInfoPanel.Visible = !accInfoPanel.Visible;
            var accountForm = new AccountForm(repatriateViewModel.Repatriate)
            {
                Location = this.Location
            };
            accountForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Hide();
        }

		private void CreateDynamicButtons(TabPage panel, ApplicationStatus status)
		{
			var applications = repatriateViewModel.Repatriate.Applications;

			if (applications != null)
			{
				switch(status)
				{
					case ApplicationStatus.UnderConsideration:
						applications = applications
							.Where(app => app.ApplicationStatus == ApplicationStatus.UnderConsideration).ToList();
						break;
					case ApplicationStatus.Approved:
						applications = applications
							.Where(app => app.ApplicationStatus == ApplicationStatus.Approved && app.ApplicationStatus == ApplicationStatus.Rejected).ToList();
						break;
				}
				

				foreach (var application in applications)
				{
					string f = "";
					switch (application.ServiceType)
					{
                        case ServiceType.RelocationProgram:
							f = "на запись для постановки на учёт в качестве участника Государственной программы переселения соотечественников";
							break;
                        case ServiceType.CompensationExpenses:
                            f = "на компенсацию расходов по найму жилья";
                            break;
                    }

					Button button = new Button
					{
						Text = Text = $"Заявка #{application.Id} {f}",
						Dock = DockStyle.Top,
						Height = 40,
						Name = application.Id.ToString()
					};
                    button.Click += buttonApllication_Click;

					this.Controls.Add(button);
					panel.Controls.Add(button);
				}
			}
		}

		private void buttonApllication_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (button != null)
			{
                var applicationInfoForm = new ApplicationInfoForm(repatriateViewModel.Repatriate.Applications.First(application => application.Id == int.Parse(button.Name)))
                {
                    Location = this.Location
                };
                applicationInfoForm.Show();
                System.Threading.Thread.Sleep(1);
                this.Hide();
            }
		}
	}
}
