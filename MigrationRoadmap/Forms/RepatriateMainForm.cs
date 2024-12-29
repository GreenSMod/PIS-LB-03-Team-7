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
	public partial class RepatriateMainForm : Form
	{
		private RepatriateViewModel repatriateViewModel;

		public RepatriateMainForm(UserModel user)
		{
			InitializeComponent();
			repatriateViewModel = new RepatriateViewModel(user);
			emailLabel.Text = user.Email;
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
	}
}
