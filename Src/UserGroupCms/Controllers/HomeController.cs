using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UserGroupCms.Models;
using UserGroupCms.Models.Contexts;

namespace UserGroupCms.Controllers
{
	[HandleError]
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			HomeContext homeContext = new HomeContext();
			homeContext.Group = UserGroup;
			homeContext.Sponsors = Company.FindAllByProperty(UserGroup, "HomePage", true);
			homeContext.SpecialContent = SpecialContent.FindAll(UserGroup);
			var futureEvents = from ev in Event.FindAll(UserGroup)
			                   where ev.Date >= DateTime.Today
			                   select ev;

			homeContext.FutureEvents = futureEvents.ToList();

			return View(homeContext);
		}

		public ActionResult About()
		{
			return View();
		}
	}
}