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

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);

			InitializeContext();
		}

		protected bool UserIsLoggedIn()
		{
			if (User == null || User.Identity == null || string.IsNullOrEmpty(User.Identity.Name))
				return false;
			else
				return true;
		}

		protected bool UserIsAdmin()
		{
			if(!UserIsLoggedIn())
				return false;

			IList<Account> accounts = Account.FindAllByProperty(UserGroup, "OpenId", User.Identity.Name);

			if(accounts.Count != 1 || !accounts[0].Admin)
				return false;

			return true;
		}
	}
}