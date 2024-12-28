using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	internal class ApplicationModel
	{
		public int Id;
		public ApplicationStatus ApplicationStatus;
		public ServiceType ServiceType;
		public List<DocumentModel> Documents;
	}
}
