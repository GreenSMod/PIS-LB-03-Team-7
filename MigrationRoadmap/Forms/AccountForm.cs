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
	public partial class AccountForm : Form
	{
		private AccountViewModel accountViewModel;

		public AccountForm(UserModel user)
		{
			InitializeComponent();
			accountViewModel = new AccountViewModel(user.Id);
		}

		private void buttonUpdateAccount_Click_1(object sender, EventArgs e)
		{
			string newEmail = emailField.Text;
			string newPassword = passField.Text;

			accountViewModel.UpdateEmail(newEmail);
			accountViewModel.UpdatePassword(newPassword);

		}
	}
}
