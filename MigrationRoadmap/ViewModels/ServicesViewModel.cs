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
	internal class ServicesViewModel
	{
		private List<ServiceModel> services;

		public ServicesViewModel()
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Services.json");
			string filePath = Path.GetFullPath(path);

			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<List<ServiceModel>>(json);

			services = data;
		}

		public ServiceModel GetServiceInfo(int serviceId)
		{
			return null;
		}

		public List<ServiceModel> GetAllServices()
		{
			return null;
		}

		public void AddService(ServiceModel newService)
		{

		}

		public void UpdateService(int serviceId, ServiceModel updatedService)
		{

		}
	}
}
