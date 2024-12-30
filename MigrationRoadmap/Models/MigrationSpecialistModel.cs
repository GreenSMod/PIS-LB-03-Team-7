using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	public class MigrationSpecialistModel : UserModel
	{
		public readonly List<ApplicationModel> Applications;

        public MigrationSpecialistModel(UserModel user) : base(user.Id, user.Email, user.Password, user.FullName, user.Role, user.Passport) { }
    }
}
