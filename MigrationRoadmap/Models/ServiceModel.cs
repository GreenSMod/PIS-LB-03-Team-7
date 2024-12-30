using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MigrationRoadmap.Models
{
	public class ServiceModel
	{
		public int Id;
		public string ServiceName;
		public string Description;
		public RegulationModel Regulation;

		[JsonConstructor]
		public ServiceModel(int id, string serviceName, string description, int regulationId)
		{
			Id = id;
			ServiceName = serviceName;
			Description = description;

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Regulations.json");
			string filePath = Path.GetFullPath(path);
			var json = File.ReadAllText(filePath);
			var data = JsonConvert.DeserializeObject<List<RegulationModel>>(json);
			Regulation = data.FirstOrDefault(r => r.Id == regulationId);
		}
	}
}
