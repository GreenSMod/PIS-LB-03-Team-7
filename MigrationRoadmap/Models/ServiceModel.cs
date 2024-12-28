using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	internal class ServiceModel
	{
		public int Id;
		public string ServiceName;
		public string Description;
		public RegulationModel Regulation;
	}
}
