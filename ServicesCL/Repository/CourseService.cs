using EntitiesCL;
using ServicesCL.IRepository;

namespace ServicesCL.Repository
{
	public class CourseService : ICourseService
	{
		public Course GetCourseByID(long courseID)
		{
			return new Course
			{
				CourseID = courseID,
				Description = "Demo course description",
				InstitutionID = 1,
				Title = "Demo Course Title"
			};
		}
	}
}
