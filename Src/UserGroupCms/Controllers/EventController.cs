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
			ViewData["Venues"] = AbstractModel<Venue>.FindAll(UserGroup);

			return base.Edit(id);
		}

		[AcceptVerbs(HttpVerbs.Post)]
		[ValidateInput(false)]
		public override ActionResult Edit(Event model)
		{
			BinderHelper.Fill(model.Sponsors, Request.Form["Sponsors"]);
			BinderHelper.Fill(model.Speakers, Request.Form["Speakers"]);
			
			model.Venue = BinderHelper.Resolve<Venue>(Request.Form["Venue"]);

			return base.Edit(model);
		}
	}
}