using EntitiesCL;

namespace ServicesCL.IRepository
{
	public interface ICourseService
	{
		Course GetCourseByID(long courseID);
	}
}
