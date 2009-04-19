using System.Collections.Generic;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public abstract class BaseController : Controller
	{
		private UserGroup userGroup;
		private bool userGroupLookupFailed;

		protected UserGroup UserGroup
		{
			get
			{
				if (userGroup == null && !userGroupLookupFailed)
				{
					IList<UserGroup> userGroups = UserGroup.FindAll();

					if (userGroups != null && userGroups.Count > 0)
						userGroup = userGroups[0];
					else
						userGroupLookupFailed = true;
				}

				return userGroup;
			}
		}

		protected virtual void InitializeContext()
		{
			if (ViewData["Group"] != null)
				return;

			if (UserGroup != null)
				ViewData["Group"] = UserGroup;
		}
	}
}