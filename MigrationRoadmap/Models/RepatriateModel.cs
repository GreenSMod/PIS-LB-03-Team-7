using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	internal class RepatriateModel : UserModel
	{
		public string PassportData;
		public List<ApplicationModel> Applications;
	}
}
