﻿using MigrationRoadmap.Models;
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
	public partial class ServiceInfoForm : Form
	{
		public ServiceInfoForm(ServiceModel service)
		{
			InitializeComponent();
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