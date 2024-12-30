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
	public partial class ServiceInfoForm : Form
	{
		private AdministratorViewModel administratorViewModel;
		private ServiceModel service;

		public ServiceInfoForm(ServiceModel service, AdministratorViewModel viewModel)
		{
			InitializeComponent();
			administratorViewModel = viewModel;
			this.service = service;
			serviceTypeLabel.Text = service.ServiceName;
			descriptionLabel.Text = service.Description;
		}

		private void buttonReturn_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm.Location = this.Location;
			Program.Context.MainForm.Show();
			System.Threading.Thread.Sleep(1);
			this.Hide();
			//this.Close();
		}


	}
}
