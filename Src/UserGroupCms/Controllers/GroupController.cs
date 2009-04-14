using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class GroupController : Controller
	{
		//
		// GET: /Group/
		public ActionResult Index()
		{
			return RedirectToAction("Edit");
		}

		public ActionResult Edit(int? id)
		{
			return View(ResolveUserGroup(id));
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Edit(UserGroup userGroup)
		{
			userGroup.SaveAndFlush();
			return RedirectToAction("List");
		}

		public ActionResult List()
		{
			return View(UserGroup.FindAll());
		}

		private UserGroup ResolveUserGroup(int? id)
		{
			UserGroup userGroup;

			if (id.HasValue)
				userGroup = UserGroup.Find(id);
			else
				userGroup = new UserGroup();

			return userGroup;
		}
	}
}