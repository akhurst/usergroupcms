using System.Collections.Generic;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public abstract class BaseModelController<T> : BaseController
		where T : AbstractModel<T>, new()
	{
		public virtual ActionResult Index()
		{
			return RedirectToAction("List");
		}

		public virtual ActionResult Create()
		{
			return RedirectToAction("Edit");
		}

		public virtual ActionResult Edit(int? id)
		{
			InitializeContext();
			return View(ResolveModel(id));
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public virtual ActionResult Edit(T model)
		{
			model.SaveAndFlush(UserGroup);
			return RedirectToAction("List");
		}

		public virtual ActionResult List()
		{
			InitializeContext();
			return View(FindAll());
		}

		protected virtual IList<T> FindAll()
		{
			return AbstractModel<T>.FindAll();
		}

		protected virtual T Find(int id)
		{
			return AbstractModel<T>.Find(id);
		}

		protected virtual T CreateNew()
		{
			return new T();
		}

		protected virtual T ResolveModel(int? id)
		{
			T model;

			if (id.HasValue)
				model = Find(id.Value);
			else
				model = CreateNew();

			return model;
		}
	}
}