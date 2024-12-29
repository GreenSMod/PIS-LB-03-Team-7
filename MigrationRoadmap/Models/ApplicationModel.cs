using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MigrationRoadmap.Models
{
	public class ApplicationModel
	{
		public readonly int Id;
        public readonly int RepatriateId;
        public readonly ApplicationStatus ApplicationStatus;
		public readonly ServiceType ServiceType;
		public readonly List<DocumentModel> Documents;

        [JsonConstructor]
        public ApplicationModel(int id, int repatriateId, ApplicationStatus applicationStatus, ServiceType serviceType, List<int> documents)
        {
            Id = id;
            RepatriateId = repatriateId;
            ApplicationStatus = applicationStatus;
            ServiceType = serviceType;

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Documents.json");
            string filePath = Path.GetFullPath(path);
            var json = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<DocumentModel>>(json);
            //Documents = data.FindAll(doc => doc.RepatriateId == null);
            Documents = new List<DocumentModel>();
            foreach (var docId in documents)
            {
                Documents.Add(data.FirstOrDefault(doc => doc.Id == docId));
            }
        }
    }
}
