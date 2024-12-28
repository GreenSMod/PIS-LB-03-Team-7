using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class MigrationSpecialistViewModel
	{
		private List<ApplicationModel> applications;

		public MigrationSpecialistViewModel()
		{

		}

		public List<ApplicationModel> FilterApplications(ServiceType serviceType)
		{
			return null;
		}

		public void ApproveApplication(int applicationId)
		{

		}

		public void RejectApplication(int applicationId, string reason)
		{

		}

		public List<ApplicationModel> GetApplicationsByStatus(ApplicationStatus status)
		{
			return null;
		}
	}
}
