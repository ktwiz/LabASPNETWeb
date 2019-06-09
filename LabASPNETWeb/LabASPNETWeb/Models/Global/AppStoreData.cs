using LabASPNETWeb.DataRepository.Linq;
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

        public static wpNew NULL_NEWS = new wpNew { id = -1 };
        public static List<wpNew> EMPTY_NEWSS= new List<wpNew>();
        public static wpUser NULL_USER = new wpUser { username = "N/A" };
        public static List<wpUser> EMPTY_USERS = new List<wpUser>();

        public static string ENCRYTION_KEY = "DuongHongTuan@2019@WebApp";


        public class PAR
        {
            public const string CF_CONNSTRNAME = "LabWebAppAspNetConnectionString";
            public const string LOGNAME_APP = "app.log";
            public const string USR_LOG = "userLogged";
            public const string MGS_AUTHFAIL = "messageFailed";
            public const string MGS_AUTHFAIL_VAL = "Wrong password or username !";
        }
    }
}