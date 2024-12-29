using MigrationRoadmap.Models;
using MigrationRoadmap.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace MigrationRoadmap.Forms
{
	public partial class AccountForm : Form
	{
		private AccountViewModel accountViewModel;

		public AccountForm(RepatriateModel repatriate)
		{
			InitializeComponent();
            ReinitializeComponent();
            accountViewModel = new AccountViewModel(repatriate);
            this.emailField.Text = repatriate.Email;
			this.nameLabel.Text = repatriate.FullName;
			this.passportLabel.Text = repatriate.Passport;

        }

		private void buttonUpdateAccount_Click(object sender, EventArgs e)
		{
            string newEmail = emailField.Text;
            string newPassword = passField.Text;

            accountViewModel.UpdateAccount(newEmail, newPassword);
            var mainForm = (RepatriateMainForm)Program.Context.MainForm;
            mainForm.UpdateRepatriate(accountViewModel.Repatriate);

            //accountViewModel.UpdateEmail(newEmail);
            //accountViewModel.UpdatePassword(newPassword);

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
