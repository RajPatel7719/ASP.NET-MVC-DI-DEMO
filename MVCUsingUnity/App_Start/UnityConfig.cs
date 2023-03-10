using ServicesCL.IRepository;
using ServicesCL.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace MVCUsingUnity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			//container.RegisterType<IInstitutionService, InstitutionService>();
			//container.RegisterType<ICourseService, CourseService>();

			container.RegisterType<IInstitutionService, InstitutionService>(new ContainerControlledLifetimeManager());
			container.RegisterType<ICourseService, CourseService>(new TransientLifetimeManager());

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}