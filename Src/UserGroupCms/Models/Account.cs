﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Account : AbstractModel<Account>
	{
		[Property]
		public string OpenId { get; set; }

		[Property]
		public bool Admin { get; set; }
	}
}
