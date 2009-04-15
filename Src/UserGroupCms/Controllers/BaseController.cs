using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public abstract class BaseController : Controller
	{
		protected virtual void InitializeContext()
		{
			if(ViewData["Group"] != null)
				return;

			IList<UserGroup> userGroups = UserGroup.FindAll();

			if(userGroups!=null && userGroups.Count>0)
				ViewData["Group"] = userGroups[0];
		}
	}
}
