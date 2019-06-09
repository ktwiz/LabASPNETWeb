using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabASPNETWeb.Models.Global
{
    public class AppStoreData
    {
        public static string CONN_STR;

        //! Log4net
        public static ILog APP_LOGGER;


        public class PAR
        {
            public const string CF_CONNSTRNAME = "LabWebAppAspNetConnectionString";
            public const string LOGNAME_APP = "app.log";
        }
    }
}