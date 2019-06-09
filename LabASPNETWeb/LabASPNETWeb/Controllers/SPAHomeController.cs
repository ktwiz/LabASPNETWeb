using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabASPNETWeb.Controllers
{
    public class SPAHomeController : Controller
    {
        // GET: SPAHome
        public ActionResult Index()
        {
            return View();
        }
    }
}