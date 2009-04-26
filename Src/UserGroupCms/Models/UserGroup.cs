using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class UserGroup : AbstractModel<UserGroup>
	{
		[Property]
		public string LogoUrl { get; set; }

		[Property]
		public string Name { get; set; }

		[Property]
		public string ShortName { get; set; }

		[Property]
		public string WelcomeMessage { get; set; }

		[Property]
		public bool Inactive { get; set; }
	}
}
