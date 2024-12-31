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
            ReinitializeComponent();
            administratorViewModel = new AdministratorViewModel(user);
			nameLabel.Text = user.FullName;
			emailLabel.Text = user.Email;
            this.MouseClick += mouseClick_accInfoPanel;
            CreateDynamicButtons();
		}

		private void CreateDynamicButtons()
		{
			var services = administratorViewModel.Services;

			if (services != null)
			{
				foreach (var service in services.OrderByDescending(ser => ser.Id))
				{
					Button button = new Button
					{
						Text = $"#{service.Id} {service.ServiceName}",
						Dock = DockStyle.Top,
						Height = 70,
						Name = service.Id.ToString()
					};
					button.Click += buttonService_Click;

					this.Controls.Add(button);
					servicesPanel.Controls.Add(button);
				}
			}
		}

		private void buttonService_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			if (button != null)
			{
				var services = administratorViewModel.Services;
				var applicationInfoForm = new ServiceInfoForm(services.First(service => service.Id == int.Parse(button.Name)), administratorViewModel)
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
