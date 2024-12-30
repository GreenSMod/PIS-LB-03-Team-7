using MigrationRoadmap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Applications.json");
			string applicationsFilePath = Path.GetFullPath(path);
			var applicationsJson = File.ReadAllText(applicationsFilePath);
			var applications = JsonConvert.DeserializeObject<List<ApplicationModel>>(applicationsJson);
			var lastId = applications.Last().Id;
			
			var newApplication = new ApplicationModel(lastId + 1, Repatriate.Id, ApplicationStatus.UnderConsideration, serviceType, null, 0, "");

			// сохранение заявки в Applications.json
			applications.Add(newApplication);
			var updatedApplicationsJson = JsonConvert.SerializeObject(applications);
			File.WriteAllText(applicationsFilePath, updatedApplicationsJson);

			// получение списка пользователей
			string usersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Users.json");
			string usersFilePath = Path.GetFullPath(usersPath);
			var usersJson = File.ReadAllText(usersFilePath);
			var users = JsonConvert.DeserializeObject<List<UserModel>>(usersJson);

			// к репатрианту по Id добавляется заявка в Users.json
			var userToUpdate = users.FirstOrDefault(user => user.Id == Repatriate.Id) as RepatriateModel;
			userToUpdate.Applications.Add(newApplication);
			var updatedUsersJson = JsonConvert.SerializeObject(users);
			File.WriteAllText(usersFilePath, updatedUsersJson);
		}
	}
}