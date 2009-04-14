using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;

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
	}
}
