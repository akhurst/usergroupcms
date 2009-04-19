using System.Web.Mvc;
using UserGroupCms.Helpers;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class EventController : BaseModelController<Event>
	{
		public override ActionResult Edit(int? id)
		{
			ViewData["Companies"] = AbstractModel<Company>.FindAll(UserGroup);
			ViewData["Speakers"] = AbstractModel<Person>.FindAll(UserGroup);

			return base.Edit(id);
		}

		public override ActionResult Edit(Event model)
		{
			BinderHelper.Fill(model.Sponsors, Request.Form["Sponsors"]);
			BinderHelper.Fill(model.Sponsors, Request.Form["Speakers"]);

			return base.Edit(model);
		}
	}
}