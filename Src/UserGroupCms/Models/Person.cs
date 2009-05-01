using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Person : AbstractModel<Person>
	{
		[Property]
		public string Name { get; set; }

		[Property]
		public string BlogUrl { get; set; }

		[Property]
		public string Url2 { get; set; }

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