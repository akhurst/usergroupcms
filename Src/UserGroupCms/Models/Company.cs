﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Company : AbstractModel<Company>
	{
		public int? CompanyId
		{
			get{ return Id;}
			set{ Id = value;}
		}

		[Property]
		public string LogoUrl { get; set; }

		[Property]
		public string Url { get; set; }

		[Property(Length = 4000)]
		public string Description { get; set; }

		[Property]
		public bool HomePage { get; set; }
	}
}
