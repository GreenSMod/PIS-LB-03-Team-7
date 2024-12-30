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

namespace MigrationRoadmap.Forms
{
	public partial class ServicesForm : Form
	{
		private AdministratorViewModel administratorViewModel;

		public ServicesForm(UserModel user)
		{
			InitializeComponent();
			administratorViewModel = new AdministratorViewModel(user);
			nameLabel.Text = user.FullName;
			emailLabel.Text = user.Email;
			CreateDynamicButtons();
		}

		private void CreateDynamicButtons()
		{
			var services = administratorViewModel.GetServices();

			if (services != null)
			{
				foreach (var service in services)
				{
					Button button = new Button
					{
						Text = Text = $"#{service.Id} {service.ServiceName}",
						Dock = DockStyle.Top,
						Height = 40,
						Name = service.Id.ToString()
					};
					button.Click += buttonApllication_Click;

					this.Controls.Add(button);
					servicesPanel.Controls.Add(button);
				}
			}
		}

		private void buttonApllication_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (button != null)
			{
				var services = administratorViewModel.GetServices();
				var applicationInfoForm = new ServiceInfoForm(services.First(service => service.Id == int.Parse(button.Name)))
				{
					Location = this.Location
				};
				applicationInfoForm.Show();
				System.Threading.Thread.Sleep(1);
				this.Hide();
			}
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
	}
}
