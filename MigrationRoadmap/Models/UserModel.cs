using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	internal class UserModel
	{
		public int Id;
		public string Email;
		public string Password;
		public string FullName;
		public RoleName Role;
	}
}
