﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;
using UserGroupCms.Models;

namespace UserGroupCms
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
					"Default",                                              // Route name
					"{controller}/{action}/{id}",                           // URL with parameters
					new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			RegisterRoutes(RouteTable.Routes);

			IConfigurationSource source = ConfigurationManager.GetSection("activerecord") as IConfigurationSource;

			ActiveRecordStarter.Initialize(source,
				typeof(UserGroup),
				typeof(Event),
				typeof(Company),
				typeof(Person),
				typeof(SpecialContent),
				typeof(Account),
				typeof(Venue));

			NHibernate.Cfg.Environment.UseReflectionOptimizer = false;
		}

		protected void Application_BeginRequest()
		{
			
		}
	}
}