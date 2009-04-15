using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class EventController : BaseModelController<Event>
	{
		public override ActionResult Edit(int? id)
		{
			ViewData["Sponsors"] = Sponsor.FindAll();
			ViewData["People"] = Person.FindAll();
			return base.Edit(id);
		}
	}
}