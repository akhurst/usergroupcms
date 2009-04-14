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
		public string Name { get; set; }
	}
}
