using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.Models
{
	internal class AdministratorModel : UserModel
	{
		private List<ServiceModel> Services;

        public AdministratorModel(UserModel user) : base(user.Id, user.Email, user.Password, user.FullName, user.Role, user.Passport) { }
    }
}
