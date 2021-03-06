﻿using LabASPNETWeb.Models.Global;
using log4net;
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

            //! Config log4net
            log4net.Config.XmlConfigurator.Configure();
            AppStoreData.APP_LOGGER = LogManager.GetLogger(AppStoreData.PAR.LOGNAME_APP);

            //! Load connection string to AppStoreData
            //? Check if connection string exists or not in web/config
            AppStoreData.CONN_STR = ConfigurationManager.ConnectionStrings[AppStoreData.PAR.CF_CONNSTRNAME].ConnectionString;
        }
    }
}
