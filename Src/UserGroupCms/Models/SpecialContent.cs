using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class SpecialContent : AbstractModel<SpecialContent>
	{
		[Property]
		public string Content { get; set; }

		[Property]
		public bool HomePage { get; set; }
	}
}
