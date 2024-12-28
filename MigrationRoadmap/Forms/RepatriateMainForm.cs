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
			repatriateViewModel = new RepatriateViewModel(user.Id);
		}

		private void buttonApplyApplicationRelocation_Click(object sender, EventArgs e)
		{
			repatriateViewModel.ApplyApplication(ServiceType.RelocationProgram);
		}

		private void buttonApplyApplicationCompensation_Click(object sender, EventArgs e)
		{
			repatriateViewModel.ApplyApplication(ServiceType.CompensationExpenses);
		}
	}
}
