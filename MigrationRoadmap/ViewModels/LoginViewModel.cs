using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class LoginViewModel
	{
		private List<UserModel> users;

		public LoginViewModel()
		{

		}

		public UserModel Authenticate(string email, string password)
		{
			return null;
		}
	}
}
