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
using System.Xml;

namespace MigrationRoadmap.Forms
{
    public partial class MigrationSpecialistConsiderForm : Form
    {
        private MigrationSpecialistViewModel migrationSpecialistViewModel;

        public MigrationSpecialistConsiderForm(UserModel user)
        {
            InitializeComponent();
            ReinitializeComponent();
            migrationSpecialistViewModel = new MigrationSpecialistViewModel(user);
            nameLabel.Text = user.FullName;
            emailLabel.Text = user.Email;
            this.MouseClick += mouseClick_accInfoPanel;
            CreateDynamicButtons(activeApplications, true);
            CreateDynamicButtons(archiveApplications, false);
        }

        private void CreateDynamicButtons(TabPage panel, bool statusIsUnderConsideration)
        {
            var applications = migrationSpecialistViewModel.MigrationSpecialist.Applications;

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
                var applicationInfoForm = new ApplicationInfoForm(migrationSpecialistViewModel.MigrationSpecialist.Applications.First(application => application.Id == int.Parse(button.Name)), migrationSpecialistViewModel)
                {
                    Location = this.Location
                };
                applicationInfoForm.Show();
                System.Threading.Thread.Sleep(1);
                this.Hide();
            }
        }

        public void UpdateApplications(int applicationId)
        {
            var btn = this.activeApplications.Controls[applicationId.ToString()];
            this.archiveApplications.Controls.Add(btn);
            this.activeApplications.Controls.Remove(btn);
            //repatriateViewModel.UpdateRepatriate(repatriate);
            //this.emailLabel.Text = repatriate.Email;
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

        private void mouseClick_accInfoPanel(object sender, MouseEventArgs e)
        {
            hideAccInfoPanel();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x210 && m.WParam.ToInt32() == 513)
            {
                hideAccInfoPanel();
            }
            base.WndProc(ref m);
        }
    }
}
