using MigrationRoadmap.Forms;
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

namespace MigrationRoadmap
{
	public partial class LoginForm : Form
	{
		private readonly LoginViewModel loginViewModel;

		public LoginForm()
		{
			InitializeComponent();
			ReinitializeComponent();
            loginViewModel = new LoginViewModel();
        }

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string email = emailField.Text;
			string password = passField.Text;

            var user = loginViewModel.Authenticate(email, password);

			if (user != null)
			{
				openRoleBasedForm(user);
			}
			else
			{
				MessageBox.Show("Неверный email или пароль");
			}
		}

		private void openRoleBasedForm(UserModel user)
		{
			Form roleForm = null;

			switch (user.Role)
			{
				case RoleName.Repatriate:
                    roleForm = new RepatriateMainForm(user);
					break;
				case RoleName.MigrationSpecialist:
					roleForm = new MigrationSpecialistConsiderForm(user);
					break;
				case RoleName.Administrator:
					roleForm = new ServicesForm(user);
					break;
			}

			roleForm.Location = this.Location;
            Program.Context.MainForm = roleForm;
            Program.Context.MainForm.Show();
            System.Threading.Thread.Sleep(1);
            this.Close();
        }
    }
}
