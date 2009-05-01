using System.Configuration;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using UserGroupCms.Models;

namespace UserGroupCms.Tests
{
	public static class TestInitializer
	{
		private static bool initialized = false;

		public static void Initialize()
		{
			if (!initialized)
			{
				InitializeActiveRecord();
				initialized = true;
			}

			ActiveRecordStarter.DropSchema();
			ActiveRecordStarter.CreateSchema();
		}

		public static void DumpSchema()
		{
			ActiveRecordStarter.GenerateCreationScripts("Create.sql");
		}

		public static void Destroy()
		{
			ActiveRecordStarter.DropSchema();
		}

		private static void InitializeActiveRecord()
		{
			IConfigurationSource source = ConfigurationManager.GetSection("activerecord") as IConfigurationSource;

			if (source == null)
				throw new InvalidTestConfigurationException();

			ActiveRecordStarter.Initialize(source,
				typeof(UserGroup),
				typeof(Event),
				typeof(Person),
				typeof(Company),
				typeof(SpecialContent),
				typeof(Account));
		}
	}
}
