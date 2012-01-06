using System;
using System.Web.Mvc;
using UserGroupCms.Models;

namespace UserGroupCms.Controllers
{
	public class UtilityController : BaseController
	{
		//
		// GET: /Utility/

		public ActionResult LoadData()
		{
				LoadBaseData();
			return RedirectToAction("Index", "Home");
		}

		public static void LoadBaseData()
		{
			UserGroup group = new UserGroup
			                  {
			                  	Name = "Aggieland .NET User's Group",
			                  	ShortName = "AggielandDNUG",
			                  	LogoUrl = "../../Content/images/aggielanddnug2.png",
			                  	WelcomeMessage =
			                  		"<p>Welcome to the website of the Aggieland .NET User's Group</p><p>Our monthly meetings are at noon on the 2nd Tuesday of each month on the Texas A&M University campus.</p>",
													ContactInfo = "<h3>Stay in touch with the DNUG</h3><ul><li>Join the mailing list<ul><li><a href=\"mailto://listserv@listserv.tamu.edu?body=subscribe%20dotnet\">by email</a></li><li><a href=\"https://listserv.tamu.edu/cgi-bin/wa?SUBED1=dotnet&A=1\">by web</a></li></ul></li><li>Follow us on <a href=\"http://twitter.com/aggielanddnug\">twitter</a></li><li>Join the <a href=\"http://www.facebook.com/groups.php?ref=sb#/group.php?gid=43083919957\">facebook group</a></li></ul>"
			                  };
			group.CreateAndFlush();

			Company improving = new Company
			                    {
			                    	Name = "Improving Enterprises",
			                    	Url = "http://improvingenterprises.com",
			                    	LogoUrl = "../../Content/images/improving200.png",
			                    	HomePage = true
			                    };
			improving.CreateAndFlush(group);

			Company microsoft = new Company
			{
				Name = "Microsoft",
				Url = "http://www.microsoft.com",
				LogoUrl = "../../Content/images/microsoft.jpg",
				HomePage = true
			};
			microsoft.CreateAndFlush(group);
			Company tamu = new Company
			{
				Name = "Texas A&M University",
				Url = "http://www.tamu.edu",
				LogoUrl = "../../Content/images/primaryWhiteMaroon.jpg",
				HomePage = true
			};
			tamu.CreateAndFlush(group);
			new Company
			{
				Name = "INETA",
				Url = "http://www.ineta.org",
				LogoUrl = "http://www.ineta.org/OfficialLogo.ashx?ugid=1",
				HomePage = true
			}.CreateAndFlush(group);
			new Company
			{Name = "O'Reilly", Url = "http://www.oreilly.com", LogoUrl = "../../Content/images/oreilly.gif", HomePage = true}.
				CreateAndFlush(group);
			new Company
			{
				Name = "DevExpress",
				Url = "http://www.devexpress.com",
				LogoUrl = "../../Content/images/devexpress.png",
				HomePage = true
			}.CreateAndFlush(group);


			new Person {Name = "Allen Hurst", Company = improving, BlogUrl = "http://ahurst.com"}.CreateAndFlush(group);
			new Person {Name = "Mike Abney", Company = improving, BlogUrl = "http://practicallyagile.com"}.CreateAndFlush(group);
			new Person {Name = "Dan Cary", Company = tamu}.CreateAndFlush(group);
			new Person {Name = "Robert Stackhouse", Company = tamu, BlogUrl = "http://robertstackhouse.com"}.CreateAndFlush(group);
			Person eric = new Person {Name = "Eric Huckabay", Company = improving};
			eric.CreateAndFlush(group);

			Venue gsc = new Venue{Name = "TAMU GSC"};
			gsc.CreateAndFlush(group);

			new SpecialContent
			{
				HomePage = true,
				Content =
					"<a href=\"http://www.oreilly.com/store/\"><img src=\"../../Content/images/oreillydiscount.gif\" alt=\"O'Reilly User Group Discount\"/></a>"
			}.CreateAndFlush(group);
			// Add special content for o'reilly user group
			// add special content for twitter feed

			// Add people with blog links

			new Event
			{
				Date = new DateTime(2009, 04, 14, 12, 0, 0),
				Name = "April Meeting: Shoving Your Code Where It Belongs",
				Speakers = new[] {eric},
				Summary =
					"Come join us for our April meeting. Mike will be covering career growth and how you can be better prepared for getting your next job, promotion, or raise. There will be door prizes provided by Microsoft and pizza provided by Improving Enterprises. Please RSVP if you plan to attend (up to 2 hours before the event) so that we don't have (another) pizza shortage!",
				Sponsors = new[] {improving, microsoft},
				EventLink1Text = "Via Facebook",
				EventLink1Url = "http://www.facebook.com/editevent.php?picture&eid=73126954537&created&new&m=1#/event.php?eid=73126954537",
				EventLink2Text = "Via Codezone",
				EventLink2Url = "https://www.ugss.codezone.com/PrivilegedUGEventView.CodezoneCom?EventID=6726",
				Venue = gsc
			}.CreateAndFlush(group);

			new Event
			{
				Date = new DateTime(2009, 05, 12, 12, 0, 0),
				Name = "May Meeting: Developing Your Development Career",
				Speakers = new[] {eric},
				Summary =
					"Come join us for our May meeting. Eric will be covering career growth and how you can be better prepared for getting your next job, promotion, or raise. There will be door prizes provided by Microsoft and pizza provided by Improving Enterprises. Please RSVP if you plan to attend (up to 2 hours before the event) so that we don't have (another) pizza shortage!",
				Sponsors = new[] {improving, microsoft},
				EventLink1Text = "Via Facebook",
				EventLink1Url = "",
				EventLink2Text = "Via Codezone",
				EventLink2Url = ""
			}.CreateAndFlush(group);

			new Account {Admin = true, OpenId = "http://ahurst.com/"}.CreateAndFlush(group);
		}
	}
}