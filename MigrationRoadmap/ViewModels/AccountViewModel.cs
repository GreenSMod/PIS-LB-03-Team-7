using MigrationRoadmap.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap.ViewModels
{
	internal class AccountViewModel
	{
        public RepatriateModel Repatriate { get; private set; }

        public AccountViewModel(RepatriateModel repatriate)
		{
			Repatriate = repatriate;
		}

		//public void GetAccountInfo()
		//{
		//}

		public void UpdateAccount(string newEmail, string newPassword)
		{
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MigrationRoadmap\Data\Users.json");
            string filePath = Path.GetFullPath(path);

            StreamReader reader = File.OpenText(filePath);
            JArray json = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
            reader.Close();

            JObject repatriate = (JObject)json[Repatriate.Id];

            repatriate["Email"] = newEmail;
            Repatriate.Email = newEmail;

            if (newPassword.Length > 0)
            {
                repatriate["Password"] = newPassword;
                Repatriate.Password = newPassword;
            }

            File.WriteAllText(filePath, json.ToString());

            
        }
    }
}
