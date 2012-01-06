using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Venue : AbstractModel<Venue>
	{
		[Property]
		public string MapImageUrl { get; set; }
	}
}
