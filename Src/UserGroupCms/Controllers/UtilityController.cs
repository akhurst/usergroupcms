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
			if (UserIsAdmin())
			{
				LoadBaseData();
			}

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
			                  		"<p>Welcome to the website of the Aggieland .NET User's Group</p><p>Our monthly meetings are at noon on the 2nd Tuesday of each month on the Texas A&M University campus.</p>"
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

			Company tamu = new Company
			               {
			               	Name = "Texas A&M University",
			               	Url = "http://www.tamu.edu",
			               	LogoUrl = "../../Content/images/primaryWhiteMaroon.jpg",
			               	HomePage = true
			               };

			new Company
			{
				Name = "Microsoft",
				Url = "http://www.microsoft.com",
				LogoUrl = "../../Content/images/microsoft.jpg",
				HomePage = true
			}.CreateAndFlush(group);
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

			tamu.CreateAndFlush(group);

			new Person {Name = "Allen Hurst", Company = improving, BlogUrl = "http://ahurst.com"}.CreateAndFlush(group);
			new Person {Name = "Mike Abney", Company = improving, BlogUrl = "http://practicallyagile.com"}.CreateAndFlush(group);
			new Person {Name = "Dan Cary", Company = tamu}.CreateAndFlush(group);
			new Person {Name = "Robert Stackhouse", Company = tamu, BlogUrl = "http://robertstackhouse.com"}.CreateAndFlush(group);
			Person eric = new Person {Name = "Eric Huckabay", Company = improving};
			eric.CreateAndFlush(group);

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
				Date = new DateTime(2009, 05, 12, 12, 0, 0),
				Title = "May Meeting: Developing Your Development Career",
				Speakers = new[] {eric},
				Summary = "Come join us for our May meeting. There will be pizza and door prizes.",
				Sponsors = new[] {improving}
			}.CreateAndFlush(group);

			new Account {Admin = true, OpenId = "http://ahurst.com/"}.CreateAndFlush(group);
		}
	}
}