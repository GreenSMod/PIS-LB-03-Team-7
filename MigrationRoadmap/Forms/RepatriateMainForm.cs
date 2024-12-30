using MigrationRoadmap.Models;
using MigrationRoadmap.ViewModels;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace MigrationRoadmap.Forms
{
	public partial class RepatriateMainForm : Form
	{
		private RepatriateViewModel repatriateViewModel;

		public RepatriateMainForm(UserModel user)
		{
			InitializeComponent();
			ReinitializeComponent();
			repatriateViewModel = new RepatriateViewModel(user);

			nameLabel.Text = user.FullName;
            emailLabel.Text = user.Email;
            this.MouseClick += mouseClick_accInfoPanel;
            CreateDynamicButtons(activeApplications, true);
            CreateDynamicButtons(archiveApplications, false);
        }

		public void UpdateRepatriate(RepatriateModel repatriate)
		{
			repatriateViewModel.UpdateRepatriate(repatriate);
			this.emailLabel.Text = repatriate.Email;
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
            accInfoPanel.Visible = false;
            var accountForm = new AccountForm(repatriateViewModel.Repatriate)
            {
                Location = this.Location
            };
            accountForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Hide();
        }

		private void hideAccInfoPanel()
		{
            var cursorX = Cursor.Position.X - this.Location.X - Cursor.Size.Width;
            var cursorY = Cursor.Position.Y - this.Location.Y - Cursor.Size.Height;
            if (accInfoPanel.Visible
            && ((cursorX < accInfoPanel.Location.X || cursorX > accInfoPanel.Location.X + accInfoPanel.Width)
            || (cursorY < accInfoPanel.Location.Y || cursorY > accInfoPanel.Location.Y + accInfoPanel.Height)))
            {
                accInfoPanel.Visible = false;
            }
        }

        private void CreateDynamicButtons(TabPage panel, bool statusIsUnderConsideration)
        {
            var applications = repatriateViewModel.Repatriate.Applications;

            if (applications != null)
            {
                if (statusIsUnderConsideration)
                    applications = applications
                            .Where(app => app.ApplicationStatus == ApplicationStatus.UnderConsideration).ToList();
                else
                    applications = applications
                            .Where(app => app.ApplicationStatus == ApplicationStatus.Approved || app.ApplicationStatus == ApplicationStatus.Rejected).ToList();

                foreach (var application in applications)
                {
                    string text = "";
                    switch (application.ServiceType)
                    {
                        case ServiceType.RelocationProgram:
                            text = "на запись для постановки на учёт в качестве участника Государственной программы переселения соотечественников";
                            break;
                        case ServiceType.CompensationExpenses:
                            text = "на компенсацию расходов по найму жилья";
                            break;
                    }

                    Button button = new Button
                    {
                        Text = $"Заявка #{application.Id} {text}",
                        Dock = DockStyle.Top,
                        Height = 70,
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

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            this.panelApplications.Visible = !this.panelApplications.Visible;
        }

        private void hidePanelApplications()
        {
            var cursorX = Cursor.Position.X - this.Location.X - Cursor.Size.Width;
            var cursorY = Cursor.Position.Y - this.Location.Y - Cursor.Size.Height;
            if (panelApplications.Visible
            && ((cursorX < panelApplications.Location.X || cursorX > panelApplications.Location.X + panelApplications.Width)
            || (cursorY < panelApplications.Location.Y || cursorY > panelApplications.Location.Y + panelApplications.Height)))
            {
                panelApplications.Visible = false;
            }
        }

        private List<int> openDocuments()
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\MigrationRoadmap\Data\{repatriateViewModel.Repatriate.Id}");
				string destinationDirectory = Path.GetFullPath(path);

				foreach (string filePath in openFileDialog.FileNames)
				{
					string newFilePath = Path.Combine(destinationDirectory, Path.GetFileName(filePath));
					File.Copy(filePath, newFilePath, true);
				}
                return repatriateViewModel.SaveDocumentsInfo(openFileDialog.FileNames);
			}
            return null;
		}

        private void buttonApplication1_Click(object sender, EventArgs e)
        {
            var listId = openDocuments();
            if (listId != null)
            {
				repatriateViewModel.ApplyApplication(ServiceType.RelocationProgram, listId);
                applicationInfoPanel.Visible = true;
                showDocuments(listId);
				RefreshDynamicButtons();
			}
		}

        private void buttonApplication2_Click(object sender, EventArgs e)
        {
			var listId = openDocuments();
			if (listId != null)
			{
				repatriateViewModel.ApplyApplication(ServiceType.CompensationExpenses, listId);
				applicationInfoPanel.Visible = true;
				showDocuments(listId);
                RefreshDynamicButtons();
			}
		}

		private void RefreshDynamicButtons()
		{
			// Очищаем содержимое панелей
			activeApplications.Controls.Clear();
			archiveApplications.Controls.Clear();

			// Пересоздаем кнопки
			CreateDynamicButtons(activeApplications, true);
			CreateDynamicButtons(archiveApplications, false);
		}

		private void mouseClick_accInfoPanel(object sender, MouseEventArgs e)
        {
            hideAccInfoPanel();
            hidePanelApplications();
            hideApplicationInfoPanel();
		}

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x210 && m.WParam.ToInt32() == 513)
            {
                hideAccInfoPanel();
                hidePanelApplications();
                hideApplicationInfoPanel();
			}
            base.WndProc(ref m);
        }

		private void showDocuments(List<int> listId)
		{
            string link = null;
			JToken document = null;
            string pathToPhoto = null;
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Documents.json");
			string filePath = Path.GetFullPath(path);

			StreamReader reader = File.OpenText(filePath);
			JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
			reader.Close();

			foreach (var id in listId)
			{
				document = json.FirstOrDefault(doc => (int)doc["Id"] == id);
				link = document["Link"].ToString();

				pathToPhoto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\MigrationRoadmap\Data\{link}");

				var pictureBox = new PictureBox
				{
					SizeMode = PictureBoxSizeMode.Zoom,
					Image = Image.FromFile(pathToPhoto),
					Width = 500,
					Height = 500,
					Dock = DockStyle.Top,
				};

				docsPanel.Controls.Add(pictureBox);
			}
		}

		private void hideApplicationInfoPanel()
		{
			var cursorX = Cursor.Position.X - this.Location.X - Cursor.Size.Width;
			var cursorY = Cursor.Position.Y - this.Location.Y - Cursor.Size.Height;
			if (applicationInfoPanel.Visible
			&& ((cursorX < applicationInfoPanel.Location.X || cursorX > applicationInfoPanel.Location.X + applicationInfoPanel.Width)
			|| (cursorY < applicationInfoPanel.Location.Y || cursorY > applicationInfoPanel.Location.Y + applicationInfoPanel.Height)))
			{
				applicationInfoPanel.Visible = false;
			}
		}
	}
}
