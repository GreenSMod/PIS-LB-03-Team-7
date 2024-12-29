using MigrationRoadmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class RepatriateViewModel
	{
		public RepatriateModel Repatriate { get; private set; }

        private readonly UserModel User;

        public RepatriateViewModel(UserModel user)
		{
			Repatriate = new RepatriateModel(user)
			{
			};

        }

		public void ApplyApplication(ServiceType serviceType)
		{
			var application = new ApplicationModel(1, 1, ApplicationStatus.UnderConsideration, ServiceType.RelocationProgram, null);
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
