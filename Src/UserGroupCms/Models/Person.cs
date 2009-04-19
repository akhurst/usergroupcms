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

		[BelongsTo]
		public Company Company { get; set; }

		[Property]
		public string Bio { get; set; }

		[Property]
		public string ImagePath { get; set; }

		[Property]
		public string CompanyName { get; set; }
	}
}