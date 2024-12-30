using MigrationRoadmap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	public class AdministratorViewModel
	{
		private List<ServiceModel> services;
		public AdministratorModel Administrator { get; private set; }

		public AdministratorViewModel(UserModel user)
		{
			Administrator = new AdministratorModel(user) { };

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Services.json");
			string filePath = Path.GetFullPath(path);

			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<List<ServiceModel>>(json);

			services = data;
		}

		public List<ServiceModel> GetServices()
		{
			return services;
		}

		public void ChangeService(string newName, string newDescription)
		{

		}

		public void ChangeRegulation(string newDeadline)
		{

		}
	}
}
