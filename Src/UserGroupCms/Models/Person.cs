using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Person : AbstractModel<Person>
	{
		[Property]
		public string Name { get; set; }

		[Property]
		public string Url { get; set; }

		[Property]
		public string CompanyName { get; set; }

		[BelongsTo]
		public Sponsor Company { get; set; }

		[Property]
		public string Bio { get; set; }
	}
}
