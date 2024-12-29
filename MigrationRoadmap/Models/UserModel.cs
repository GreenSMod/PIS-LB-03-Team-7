using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MigrationRoadmap.Models
{
	public class UserModel
	{
		public readonly int Id;
		public readonly string Email;
		public readonly string Password;
		public readonly string FullName;
		public readonly RoleName Role;
        // поля Репатрианта
        public readonly string Passport;


        [JsonConstructor]
        public UserModel(int id, string email, string password, string fullName, RoleName role, string passport)
        {
            Id = id;
            Email = email;
            Password = password;
            FullName = fullName;
            Role = role;
            Passport = passport;
        }
    }
}
