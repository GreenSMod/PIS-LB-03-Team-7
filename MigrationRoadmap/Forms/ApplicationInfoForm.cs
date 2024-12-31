using MigrationRoadmap.Models;
using MigrationRoadmap.ViewModels;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
using System.Diagnostics;

namespace MigrationRoadmap.Forms
{
	public partial class ApplicationInfoForm : Form
	{
		private MigrationSpecialistViewModel migrationSpecialistViewModel;
		private ApplicationModel application;

		//public ApplicationInfoForm()
		//{
		//	InitializeComponent();
  //          ReinitializeComponent();
  //      }

        public ApplicationInfoForm(ApplicationModel application)
        {
            InitializeComponent();
			ReinitializeComponent();
            this.Text = "ЗАЯВКА #" + application.Id.ToString();
			//repatriateViewModel = new RepatriateViewModel(user);
			serviceTypeLabel.Text = application.ServiceType.ToString();
			statusLabel.Text = application.ApplicationStatus.ToString();
			translateForUser(application);
			showDocuments(application);
			if (application.ApplicationStatus == ApplicationStatus.Rejected)
			{
				rejectionLabel.Visible = true;
				rejectionReasonLabel.Text = application.RejectReason;
				rejectionReasonLabel.Visible = true;
			}
			//this.application = application;
			if (application.ApplicationStatus != ApplicationStatus.UnderConsideration)
			{
				var id = application.MigrationSpecialistId;
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Users.json");
				string filePath = Path.GetFullPath(path);

				StreamReader reader = File.OpenText(filePath);
				JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
				reader.Close();

				var user = json.FirstOrDefault(u => (int)u["Id"] == id);
				nameSpecialistLabel.Text = user["FullName"].ToString();

				checkedLabel.Visible = true;
				nameSpecialistLabel.Visible = true;
			}
		}

		public ApplicationInfoForm(ApplicationModel application, MigrationSpecialistViewModel viewModel) : this(application)
		{
			migrationSpecialistViewModel = viewModel;
			this.application = application;
			if (application.ApplicationStatus == ApplicationStatus.UnderConsideration)
				updatePermissions();
		}

		private void updateMainForm(int applicationId)
		{
            //migrationSpecialistViewModel.UpdateAccount(newEmail, newPassword);
            var mainForm = (MigrationSpecialistConsiderForm)Program.Context.MainForm;
            mainForm.UpdateApplications(applicationId);

        }

		private void returnToMainForm()
		{
            Program.Context.MainForm.Location = this.Location;
            Program.Context.MainForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Hide();
            //this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
			returnToMainForm();
        }

		private void updatePermissions()
		{
			buttonApprove.Enabled = true;
			buttonApprove.Visible = true;
			buttonReject.Enabled = true;
			buttonReject.Visible = true;
			reasonField.Enabled = true;
			reasonField.Visible = true;
            reasonLabel.Visible = true;

        }

		private void translateForUser(ApplicationModel application)
		{
			var id = (int)application.ServiceType + 1;
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Services.json");
			string filePath = Path.GetFullPath(path);

			StreamReader reader = File.OpenText(filePath);
			JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
			reader.Close();

			var service = json.FirstOrDefault(ser => (int)ser["Id"] == id);
			var st = service["ServiceName"].ToString();
			serviceTypeLabel.Text = $"{st}";

			//string st = "";
			//switch (serviceTypeLabel.Text)
			//{
			//	case "RelocationProgram":
			//		st = "на запись для постановки на учёт в качестве участника Государственной программы переселения соотечественников";
			//		break;
			//	case "CompensationExpenses":
			//		st = "на компенсацию расходов по найму жилья";
			//		break;
			//}
			//serviceTypeLabel.Text = $"Заявка {st}";

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
						Name = document.Link
                    };

                    pictureBox.MouseClick += new MouseEventHandler((o, a) => 
					{
                        Process.Start(path);
                    });

                    docsPanel.Controls.Add(pictureBox);
				}
		}

		private void buttonApprove_Click(object sender, EventArgs e)
		{
			migrationSpecialistViewModel.UpdateApplication(application.Id, ApplicationStatus.Approved, reasonField.Text);
			this.updateMainForm(application.Id);
            this.returnToMainForm();
        }

        private void buttonReject_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(reasonField.Text))
				MessageBox.Show("Укажите причину отказа");
			else
			{
                migrationSpecialistViewModel.UpdateApplication(application.Id, ApplicationStatus.Rejected, reasonField.Text);
                this.updateMainForm(application.Id);
                this.returnToMainForm();
            }
		}
	}
}
