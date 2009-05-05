using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class UserGroupController : BaseModelController<UserGroup>
	{
		public override ActionResult Edit(int? id)
		{
			if (UserGroup != null && !UserIsAdmin())
				return RedirectToAction("List");

			return View(ResolveModel(id));
		}

		[ValidateInput(false)]
		[AcceptVerbs(HttpVerbs.Post)]
		public override ActionResult Edit(UserGroup model)
		{
			if (UserGroup!= null && !UserIsAdmin())
				return RedirectToAction("List");

			model.SaveAndFlush();
			return RedirectToAction("List");
		}
	}
}