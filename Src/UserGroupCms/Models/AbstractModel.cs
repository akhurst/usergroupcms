using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;
using NHibernate.Expression;

namespace UserGroupCms.Models
{
	public abstract class AbstractModel<T> : ActiveRecordBase<T>
	{
		[PrimaryKey]
		public int? Id{get;set;}

		[Property]
		public int UserGroupId { get; set; }

		public bool IsNew
		{
			get { return !Id.HasValue; }
		}

		public void CreateAndFlush(UserGroup userGroup)
		{
			CreateAndFlush(userGroup.Id.Value);
		}

		public void CreateAndFlush(int userGroupId)
		{
			UserGroupId = userGroupId;

			CreateAndFlush();
		}

		public void SaveAndFlush(UserGroup userGroup)
		{
			SaveAndFlush(userGroup.Id.Value);
		}

		public void SaveAndFlush(int userGroupId)
		{
			UserGroupId = userGroupId;

			SaveAndFlush();
		}

		public static IList<T> FindAll(UserGroup userGroup)
		{
			return FindAll(userGroup.Id.Value);
		}

		public static IList<T> FindAll(int userGroupId)
		{
			return FindAllByProperty("UserGroupId", userGroupId);
		}

		public static IList<T> FindAllByProperty(UserGroup userGroup, string propertyName, object value)
		{
			return FindAllByProperty(userGroup.Id.Value, propertyName, value);
		}

		public static IList<T> FindAllByProperty(int userGroupId, string propertyName, object value)
		{
			return FindAll(new EqExpression("UserGroupId", userGroupId), new EqExpression(propertyName, value));
		}
	}
}
