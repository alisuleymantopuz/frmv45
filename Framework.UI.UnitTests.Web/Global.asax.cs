using Framework.Mvc.Utility.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Framework.UI.UnitTests.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterBinders();
        }

        private static void RegisterBinders()
        {
            ModelBinders.Binders.Add(typeof(DateTime), new DatetimeBinder());
            ModelBinders.Binders.Add(typeof(Decimal), new DecimalBinder());
        }
    }
}