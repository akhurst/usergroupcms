using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UserGroupCms.Helpers;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class PersonController : BaseModelController<Person>
	{
		public override ActionResult Edit(int? id)
		{
			var dbCompanies = AbstractModel<Company>.FindAll(UserGroup);
			var viewCompanies = new List<Company>(dbCompanies);
			viewCompanies.Add(new Company{Id = 0,Name = "", UserGroupId = base.UserGroup.Id.Value});
			viewCompanies.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
			ViewData["Companies"] = viewCompanies;

			return base.Edit(id);
		}

		public override ActionResult Edit(Person model)
		{
			string companiesList = Request.Form["CompaniesList"];

			if(companiesList != string.Empty && companiesList != "0")
				model.Company = BinderHelper.Resolve<Company>(Request.Form["CompaniesList"]);
			else
				model.Company = null;

			return base.Edit(model);
		}
	}
}