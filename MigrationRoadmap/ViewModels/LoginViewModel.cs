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
		private List<UserModel> users;

		public LoginViewModel()
		{
			//string basePath = AppDomain.CurrentDomain.BaseDirectory;
			//string filePath = Path.Combine(basePath, "Jsons", "Users.json");

			var filePath = "C:\\Users\\IVAN\\source\\repos\\PIS-LB-03-Team-7\\MigrationRoadmap\\Jsons\\Users.json";
			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<UserModel>(json);

			users = new List<UserModel>();
			users.Add(data);
		}

		public UserModel Authenticate(string email, string password)
		{
			return users.FirstOrDefault(user => user.Email == email && user.Password == password);
		}
	}
}
