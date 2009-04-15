using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Event : AbstractModel<Event>
	{
		[Property]
		public DateTime Date { get; set; }

		[Property]
		public string Title { get; set; }

		[HasAndBelongsToMany(Table = "EventSpeakers", ColumnKey="eventid", ColumnRef="speakerid")]
		public IList<Person> Speakers { get; set; }

		[HasAndBelongsToMany(Table = "EventSponsors", ColumnKey="eventid", ColumnRef="sponsorid")]
		public IList<Sponsor> Sponsors { get; set; }

		[Property]
		public string Summary { get; set; }

		[Property]
		public string EventLink { get; set; }

		[Property]
		public string ArtifactsUrl { get; set; }
	}
}
