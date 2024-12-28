using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class ApplicationsViewModel
	{
		private List<RepatriateModel> users;
		private List<ApplicationModel> applications;

		public ApplicationsViewModel()
		{

		}

		public List<ApplicationModel> GetApplicationsByUser(int userId)
		{
			return null;
		}

		public List<ApplicationModel> GetApplicationsByStatus(ApplicationStatus status)
		{
			return null;
		}

		public void AddApplication(int userId, ApplicationModel newApplication)
		{

		}

		public void UpdateApplicationStatus(int applicationId, ApplicationStatus newStatus)
		{

		}
	}
}
