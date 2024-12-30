using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace MigrationRoadmap.Models
{
	public class RegulationModel
	{
		public int Id;
		public string Deadline;

		[JsonConstructor]
		public RegulationModel(int id, string deadline)
		{
			Id = id;
			Deadline = deadline;
		}
	}
}
