using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MigrationRoadmap.Models
{
	public class DocumentModel
	{
		public readonly int Id;
        public readonly int RepatriateId;
        public readonly DocumentType DocumentType;
		public readonly string Link;

        [JsonConstructor]
        public DocumentModel(int id, int repatriateId, DocumentType documentType, string link)
		{
            Id = id;
            RepatriateId = repatriateId;
            DocumentType = documentType;
			Link = link;
        }
    }
}
