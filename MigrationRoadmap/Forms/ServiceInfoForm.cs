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
			serviceNameLabel.Text = service.ServiceName;
			descriptionLabel.Text = service.Description;
			deadlineLabel.Text = administratorViewModel.Regulations.FirstOrDefault(r => r.Id == service.RegulationId).Deadline;
			this.service = service;
        }

		private void buttonReturn_Click(object sender, EventArgs e)
		{
			Program.Context.MainForm.Location = this.Location;
			Program.Context.MainForm.Show();
			System.Threading.Thread.Sleep(1);
			this.Hide();
			//this.Close();
		}

		private void buttonChangeService_Click(object sender, EventArgs e)
		{
			buttonChangeService.Visible = !buttonChangeService.Visible;
			serviceNameField.Visible = !serviceNameField.Visible;
			descriptionField.Visible = !descriptionField.Visible;
            buttonSaveServiceChange.Visible = !buttonSaveServiceChange.Visible;

        }

		private void buttonChangeRegulation_Click(object sender, EventArgs e)
		{
			buttonChangeRegulation.Visible = !buttonChangeRegulation.Visible;
			deadlineField.Visible = !deadlineField.Visible;
            buttonSaveRegulationChange.Visible = !buttonSaveRegulationChange.Visible;
        }

		private void buttonSaveServiceChange_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(serviceNameField.Text) || string.IsNullOrWhiteSpace(descriptionField.Text))
			{
				MessageBox.Show("Поля не должны быть пустыми");
			}
			else
			{
				administratorViewModel.ChangeService(service.Id, serviceNameField.Text, descriptionField.Text);
			}
		}

		private void buttonSaveRegulationChange_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(deadlineField.Text))
			{
				MessageBox.Show("Поле не должно быть пустым");
			}
			else
			{
				administratorViewModel.ChangeRegulation(service.RegulationId, deadlineField.Text);
			}
		}
	}
}
