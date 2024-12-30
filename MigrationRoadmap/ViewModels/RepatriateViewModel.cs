using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	public class RepatriateViewModel
	{
		public RepatriateModel Repatriate { get; private set; }

        public RepatriateViewModel(UserModel user)
		{
			Repatriate = new RepatriateModel(user) { };
        }

		public void UpdateRepatriate(RepatriateModel repatriate)
		{
			Repatriate = repatriate;
		}

		public void ApplyApplication(ServiceType serviceType)
		{
			var application = new ApplicationModel(1, 1, ApplicationStatus.UnderConsideration, ServiceType.RelocationProgram, null, 2, "");
			//{
			//	// Id
			//	ApplicationStatus = ApplicationStatus.UnderConsideration,
			//	ServiceType = serviceType
			//	//Documents;
			//};
			// к репатрианту по Id добавляется заявка в Users.json
			// сохранить заявку в Applications.json
		}
	}
}
