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
		public List<ServiceModel> Services { get; }
        public List<RegulationModel> Regulations { get; }
        public AdministratorModel Administrator { get; private set; }

		public AdministratorViewModel(UserModel user)
		{
			Administrator = new AdministratorModel(user) { };

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Services.json");
			string filePath = Path.GetFullPath(path);
			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<List<ServiceModel>>(json);
            Services = data;

            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Regulations.json");
            string filePath2 = Path.GetFullPath(path2);
            var json2 = File.ReadAllText(filePath2);
            var data2 = JsonConvert.DeserializeObject<List<RegulationModel>>(json2);
			Regulations = data2;
		}

		//public List<ServiceModel> GetServices()
		//{
		//	return Services;
		//}

		public void ChangeService(string newName, string newDescription)
		{

		}

		public void ChangeRegulation(string newDeadline)
		{

		}
	}
}
