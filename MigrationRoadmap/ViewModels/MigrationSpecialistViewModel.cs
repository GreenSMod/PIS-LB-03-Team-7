using MigrationRoadmap.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	public class MigrationSpecialistViewModel
	{
        public MigrationSpecialistModel MigrationSpecialist { get; private set; }

        public MigrationSpecialistViewModel(UserModel user)
        {
            MigrationSpecialist = new MigrationSpecialistModel(user) { };
        }

        //private List<ApplicationModel> applications;
		
		

		//public List<ApplicationModel> FilterApplications(ServiceType serviceType)
		//{
		//	return null;
		//}

		//public void ApproveApplication(int applicationId)
		//{

		//}

		//public void RejectApplication(int applicationId, string reason)
		//{

		//}

        public void UpdateApplication(int applicationId, ApplicationStatus newApplicationStatus, string newRejectReason)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Applications.json");
            string filePath = Path.GetFullPath(path);

            StreamReader reader = File.OpenText(filePath);
            JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();

            JObject application = (JObject)json[applicationId - 1];

            application["ApplicationStatus"] = newApplicationStatus.ToString();

            application["MigrationSpecialistId"] = MigrationSpecialist.Id;

            if (newApplicationStatus == ApplicationStatus.Rejected)
            {
                application["RejectReason"] = newRejectReason;
            }

            var appToChange = MigrationSpecialist.Applications.First(app => app.Id == applicationId);
            appToChange.ChangeApplication(newApplicationStatus, MigrationSpecialist.Id, newRejectReason);

            File.WriteAllText(filePath, json.ToString());
        }

  //      public List<ApplicationModel> GetApplicationsByStatus(ApplicationStatus status)
		//{
		//	return null;
		//}
	}
}
