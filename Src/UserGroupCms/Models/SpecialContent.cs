using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class SpecialContent : AbstractModel<SpecialContent>
	{
		[Property(Length = 4000)]
		public string Content { get; set; }

		[Property]
		public bool HomePage { get; set; }
	}
}
