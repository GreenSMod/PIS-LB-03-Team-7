using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	public class RepatriateModel : UserModel
	{
		private readonly List<ApplicationModel> Applications;

		public RepatriateModel(UserModel user) : base(user.Id, user.Email, user.Password, user.FullName, user.Role, user.Passport)
		{
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Applications.json");
            string filePath = Path.GetFullPath(path);

            var json = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<ApplicationModel>>(json);

            Applications = data.FindAll(application => application.RepatriateId == user.Id);
            Applications = null;
        }
	}
}
