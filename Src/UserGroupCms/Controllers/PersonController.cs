using System.Web.Mvc;
using UserGroupCms.Helpers;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class PersonController : BaseModelController<Person>
	{
		public override ActionResult Edit(int? id)
		{
			ViewData["Companies"] = AbstractModel<Company>.FindAll(UserGroup);

			return base.Edit(id);
		}

		public override ActionResult Edit(Person model)
		{
			model.Company = BinderHelper.Resolve<Company>(Request.Form["Company"]);

			return base.Edit(model);
		}
	}
}