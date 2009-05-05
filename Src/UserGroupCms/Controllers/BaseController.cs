using System.Collections.Generic;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public abstract class BaseController : Controller
	{
		private UserGroup userGroup;
		private Account userAccount;
		private bool userGroupLookupFailed;
		private bool userAccountLookupFailed;

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

		protected Account UserAccount
		{
			get
			{
				if(!UserIsLoggedIn())
					return null;

				if (userAccount == null && !userAccountLookupFailed)
				{
					IList<Account> accounts = Account.FindAllByProperty(UserGroup, "OpenId", User.Identity.Name);

					if (accounts!=null && accounts.Count == 1)
						userAccount = accounts[0];
					else
						userAccountLookupFailed = true;
				}

				return userAccount;
			}
		}

		protected virtual void InitializeContext()
		{
			if (ViewData["Group"]==null && UserGroup != null)
				ViewData["Group"] = UserGroup;

			if (ViewData["UserAccount"]==null && UserAccount != null)
				ViewData["UserAccount"] = UserAccount;
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
			if (UserAccount == null)
				return false;
			else
				return UserAccount.Admin;
		}
	}
}