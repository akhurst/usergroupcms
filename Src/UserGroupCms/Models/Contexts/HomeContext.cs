using System.Collections.Generic;

namespace UserGroupCms.Models.Contexts
{
	public class HomeContext
	{
		public IList<Company> Sponsors { get; set; }
		public UserGroup Group { get; set; }
		public IList<Event> FutureEvents { get; set; }
		public IList<SpecialContent> SpecialContent { get; set; }
	}
}