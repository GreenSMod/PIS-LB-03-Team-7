using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationRoadmap
{
	public enum RoleName
	{
		Repatriate,
		MigrationSpecialist,
		Administrator
	}

	public enum ApplicationStatus
	{
		UnderConsideration,
		Approved,
		Rejected
	}

	public enum DocumentType
	{
		Passport
	}

	public enum ServiceType
	{
		RelocationProgram,
		CompensationExpenses
	}
}
