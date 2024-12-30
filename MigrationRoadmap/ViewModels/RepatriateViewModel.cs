using MigrationRoadmap.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

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

		public List<int> SaveDocumentsInfo(string[] filePaths)
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Documents.json");
			string filePath = Path.GetFullPath(path);

			StreamReader reader = File.OpenText(filePath);
			JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
			reader.Close();
			var listId = new List<int>();
			foreach (var file in filePaths)
			{
				var lastId = (int)json.Last["Id"];

				var fileName = Path.GetFileName(file);
				JObject newDocument = new JObject
				{
					["Id"] = lastId + 1,
					["RepatriateId"] = Repatriate.Id,
					["DocumentType"] = DocumentType.Passport.ToString(),
					["Link"] = $"\\{Repatriate.Id}\\{fileName}"
				};
				json.Add(newDocument);
				listId.Add(lastId + 1);
			}
				
			File.WriteAllText(filePath, json.ToString());

			return listId;
		}

		public void ApplyApplication(ServiceType serviceType, List<int> documents)
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Applications.json");
			string filePath = Path.GetFullPath(path);

			StreamReader reader = File.OpenText(filePath);
			JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
			reader.Close();

			var lastId = (int)json.Last["Id"];
			JObject newApplication = new JObject
			{
				["Id"] = lastId + 1,
				["repatriateId"] = Repatriate.Id,
				["applicationStatus"] = ApplicationStatus.UnderConsideration.ToString(),
				["serviceType"] = serviceType.ToString(),
				["documents"] = new JArray(documents),
				["migrationSpecialistId"] = 0,
				["rejectReason"] = string.Empty
			};

			json.Add(newApplication);
			File.WriteAllText(filePath, json.ToString());
			Repatriate.Applications.Add(new ApplicationModel(lastId + 1, Repatriate.Id, ApplicationStatus.UnderConsideration, serviceType, documents, 0, ""));
		}
	}
}