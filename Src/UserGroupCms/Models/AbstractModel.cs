using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	public abstract class AbstractModel<T> : ActiveRecordBase<T>
	{
		[PrimaryKey]
		public int? Id{get;set;}

		public bool IsNew
		{
			get { return !Id.HasValue; }
		}	
	}
}
