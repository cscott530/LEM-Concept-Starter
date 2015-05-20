using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LEM.Core.Attributes;
using LEM.Managers;

namespace LEM
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //get all items that are registered as 'startup' items
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetCustomAttributes(typeof(ManagerAttribute), true).Length > 0)
                    {
                        //do this as a blind cast. if it fails the app should hard crash, anyway.
                        var manager = (IManager) Activator.CreateInstance(type);
                        manager.Startup();
                    }
                }
            }
        }
    }
}
