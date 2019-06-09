using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LabASPNETWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //! Load connection string to AppStoreData
            AppStoreData.CONN_STR = ConfigurationManager.ConnectionStrings[AppStoreData.PAR.CF_CONNSTRNAME].ConnectionString;
        }
    }
}
