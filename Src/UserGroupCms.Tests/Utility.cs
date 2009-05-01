using System;
using MbUnit.Framework;
using UserGroupCms.Controllers;
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
		public void DumpScript()
		{
			CreateAndFill();
			TestInitializer.DumpSchema();
		}

		[Test, Explicit]
		public void CreateAndFill()
		{
			TestInitializer.Initialize();

			UtilityController.LoadBaseData();
		}
	}
}