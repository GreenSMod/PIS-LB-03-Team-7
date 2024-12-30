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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MigrationRoadmap.Models
{
	public class ApplicationModel
	{
		public int Id { get; private set; }
        public int RepatriateId { get; private set; }
        public ApplicationStatus ApplicationStatus { get; private set; }
        public ServiceType ServiceType { get; private set; }
        public List<DocumentModel> Documents { get; private set; }
        public int MigrationSpecialistId { get; private set; }
        public string RejectReason { get; private set; }

        [JsonConstructor]
        public ApplicationModel(int id, int repatriateId, ApplicationStatus applicationStatus, ServiceType serviceType, List<int> documents, int migrationSpecialistId, string rejectReason)
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

            MigrationSpecialistId = migrationSpecialistId;
            RejectReason = rejectReason;
        }

        public void ChangeApplication(ApplicationStatus newApplicationStatus, int migrationSpecialistId, string newRejectReason)
        {
            ApplicationStatus = newApplicationStatus;
            MigrationSpecialistId = migrationSpecialistId;
            RejectReason = newRejectReason;
        }
    }
}
