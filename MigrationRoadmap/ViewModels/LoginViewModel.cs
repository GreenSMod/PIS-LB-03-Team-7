using MigrationRoadmap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class LoginViewModel
	{
		private readonly List<UserModel> users;

		public LoginViewModel()
		{
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Json\Users.json");
            string filePath = Path.GetFullPath(path);

			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<List<UserModel>>(json);

			users = data;
		}

		public UserModel Authenticate(string email, string password)
		{
			return users.FirstOrDefault(user => user.Email == email && user.Password == password);
		}
	}
}
