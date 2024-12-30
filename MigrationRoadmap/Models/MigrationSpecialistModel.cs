using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationRoadmap.Models
{
	public class MigrationSpecialistModel : UserModel
	{
		public readonly List<ApplicationModel> Applications;

        public MigrationSpecialistModel(UserModel user) : base(user.Id, user.Email, user.Password, user.FullName, user.Role, user.Passport)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Applications.json");
            string filePath = Path.GetFullPath(path);

            var json = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<ApplicationModel>>(json);

            Applications = data.FindAll(application => application.ApplicationStatus == ApplicationStatus.UnderConsideration);
            Applications.AddRange(data.FindAll(application => application.ApplicationStatus != ApplicationStatus.UnderConsideration && application.MigrationSpecialistId == user.Id));
        }
    }
}
