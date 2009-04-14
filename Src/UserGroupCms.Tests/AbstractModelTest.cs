using MbUnit.Framework;

namespace UserGroupCms.Tests
{
	[TestFixture]
	public abstract class AbstractModelTest
	{
		[SetUp]
		public virtual void CreateSchema()
		{
			TestInitializer.Initialize();
		}

		[TearDown]
		public virtual void DestroySchema()
		{
			TestInitializer.Destroy();
		}
	}
}
