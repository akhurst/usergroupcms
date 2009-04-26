using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class SpecialContent : AbstractModel<SpecialContent>
	{
		[Property]
		public string Title { get; set; }

		[Property]
		public string Description { get; set; }

		[Property]
		public string ImageUrl { get; set; }

		[Property]
		public string LinkUrl { get; set; }
	}
}
