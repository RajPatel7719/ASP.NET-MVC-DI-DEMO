using EntitiesCL;
using ServicesCL.IRepository;

namespace ServicesCL.Repository
{
	public class InstitutionService : IInstitutionService
	{
		public Institution GetInstitutionByID(long institutionID)
		{
			return new Institution
			{
				InstitutionID = institutionID,
				Name = "Demo Institution",
				Address = "Demo Address",
				Telephone = "0123456789"
			};
		}
	}
}
