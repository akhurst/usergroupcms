using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using Castle.ActiveRecord;

namespace UserGroupCms.Models
{
	[ActiveRecord]
	public class Event : AbstractModel<Event>
	{
		[Property]
        [Required(ErrorMessage = "Event must have a date")]
		public DateTime Date { get; set; }

		[Property]
        [Required(ErrorMessage = "Event must have a title")]
		public string Title { get; set; }

		[HasAndBelongsToMany(Table = "EventSpeakers", ColumnKey="eventid", ColumnRef="speakerid")]
		public IList<Person> Speakers { get; set; }

		[HasAndBelongsToMany(Table = "EventSponsors", ColumnKey="eventid", ColumnRef="sponsorid")]
		public IList<Company> Sponsors { get; set; }

		[Property(Length = 4000)]
		public string Summary { get; set; }

		[Property]
		public string EventLink1Text { get; set; }

		[Property]
		public string EventLink1Url { get; set; }

		[Property]
		public string EventLink2Text { get; set; }

		[Property]
		public string EventLink2Url { get; set; }

		[Property]
		public string ArtifactsUrl { get; set; }

		[BelongsTo]
		public Venue Venue { get; set; }

		public int? VenueId
		{
			get
			{
				if (Venue != null)
					return Venue.Id;
				else
					return null;
			}
		}

		public string SpeakersString
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				foreach (Person person in Speakers)
				{
					if (sb.Length > 0)
						sb.Append(", ");

					sb.Append(person.Name);
				}

				return sb.ToString();
			}
		}
	}
}
