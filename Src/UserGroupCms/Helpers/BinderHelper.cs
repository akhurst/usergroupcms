using System;
using System.Collections.Generic;
using Castle.ActiveRecord;
using UserGroupCms.Models;

namespace UserGroupCms.Helpers
{
	public static class BinderHelper
	{
		public static void Fill<T>(IList<T> list, string delimitedIds) where T : AbstractModel<T>
		{
			if (!string.IsNullOrEmpty(delimitedIds))
			{
				string[] ids = delimitedIds.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

				foreach (string id in ids)
					list.Add(ActiveRecordBase<T>.Find(Convert.ToInt32(id)));
			}
		}

		public static T Resolve<T>(string idStr) where T : AbstractModel<T>
		{
			if (!string.IsNullOrEmpty(idStr))
			{
				return ActiveRecordBase<T>.Find(Convert.ToInt32(idStr));
			}
			else
			{
				return null;
			}
		}
	}
}