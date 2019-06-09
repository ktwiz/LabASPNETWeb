using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabASPNETWeb.Controllers
{
    public class HomeController : Controller
    {
        //! GET: Home
        public ActionResult Index()
        {
            //x AppStoreData.APP_LOGGER.Info("Enter: Home/Index");
            return View();
        }
    }
}