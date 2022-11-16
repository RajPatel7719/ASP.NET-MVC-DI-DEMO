using EntitiesCL;

namespace ServicesCL.IRepository
{
	public interface IInstitutionService
	{
		Institution GetInstitutionByID(long institutionID);
	}
}
