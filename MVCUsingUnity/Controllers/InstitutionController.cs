using ServicesCL.IRepository;
using System.Web.Mvc;

namespace MVCUsingUnity.Controllers
{
	public class InstitutionController : Controller
	{
		private readonly IInstitutionService institutionService;
		public InstitutionController(IInstitutionService institutionService)
		{
			this.institutionService = institutionService;
		}
		public ActionResult Index()
		{
			return View(institutionService.GetInstitutionByID(1));
		}
	}
}