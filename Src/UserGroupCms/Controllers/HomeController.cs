using System.Web.Mvc;

namespace UserGroupCms.Controllers
{
	[HandleError]
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			InitializeContext();
			


			return View();
		}

		public ActionResult About()
		{
			InitializeContext();
			return View();
		}
	}
}