using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class AdministratorViewModel
	{
		private List<ServiceModel> services;
		public AdministratorModel Administrator { get; private set; }

		public AdministratorViewModel(UserModel user)
		{
			Administrator = new AdministratorModel(user) { };
		}

		public List<ServiceModel> GetServices()
		{
			return null;
		}

		public void ChangeService(int serviceId, string newDescription)
		{

		}

		public void ChangeRegulation(int serviceId, RegulationModel newRegulation)
		{

		}
	}
}
