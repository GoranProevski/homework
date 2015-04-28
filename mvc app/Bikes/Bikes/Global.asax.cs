using Register.Common;
using Register.DataLayer;
using Register.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bikes
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RepositoryManager.RegisterFactory(new DefaultRepositoryFactory());
            ContextManager.RegisterContextFactory(new ContextFactory());
            LoggManager.RegisterLogger(new LoggerFactory());
        }
    }
}
