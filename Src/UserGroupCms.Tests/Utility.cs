using System;
using MbUnit.Framework;
using UserGroupCms.Models;

namespace UserGroupCms.Tests
{
	[TestFixture]
	public class Utility
	{
		[Test, Explicit]
		public void CreateSchema()
		{
			TestInitializer.Initialize();
		}

		[Test, Explicit]
		public void CreateAndFill()
		{
			TestInitializer.Initialize();

			UserGroup group = new UserGroup {Name = "Aggieland .NET User's Group", ShortName = "AggielandDNUG", LogoUrl = "../../Content/images/aggielanddnug2.png"};
			group.CreateAndFlush();

			Company improving = new Company
			                    {
			                    	Name = "Improving Enterprises",
			                    	Url = "http://improvingenterprises.com",
			                    	LogoUrl = "../../Content/images/improving.png",
			                    	HomePage = true
			                    };
			improving.CreateAndFlush(group);

			Company tamu = new Company
			               {Name = "Texas A&M University", Url = "http://www.tamu.edu", LogoUrl = "../../Content/images/tamu.png"};
			tamu.CreateAndFlush(group);

			Person allen = new Person {Name = "Allen Hurst", Company = improving, Url = "http://ahurst.com"};
			allen.CreateAndFlush(group);
			new Person {Name = "Mike Abney", Company = improving, Url = "http://practicallyagile.com"}.CreateAndFlush(group);
			new Person {Name = "Eric Huckabay", Company = improving}.CreateAndFlush(group);
			new Person {Name = "Dan Cary", Company = tamu}.CreateAndFlush(group);
			new Person {Name = "Robert Stackhouse", Company = tamu, Url = "http://robertstackhouse.com" }.CreateAndFlush(group);

			new Event
			{Date = DateTime.Today.AddDays(1), Title = "Test Event", Speakers = new[] {allen}, Summary = "This is a test event", Sponsors = new[]{improving}}.CreateAndFlush(group);
		}
	}
}