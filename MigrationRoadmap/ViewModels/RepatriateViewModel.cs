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

		public RepatriateViewModel(int userId)
		{
			// Загрузить репатрианта по Id
		}

		public void ApplyApplication(ServiceType serviceType)
		{
			var application = new ApplicationModel
			{
				// Id
				ApplicationStatus = ApplicationStatus.UnderConsideration,
				ServiceType = serviceType
				//Documents;
			};
			// к репатрианту по Id добавляется заявка в Users.json
			// сохранить заявку в Applications.json
		}
	}
}
