using LabASPNETWeb.DataRepository;
using LabASPNETWeb.DataRepository.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabASPNETWeb.Controllers
{
    public class SPAHomeController : Controller
    {
        private INews newsRep = new LinqNewsRep();

        // GET: SPAHome
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult loadAllNews()
        {
            List<wpNew> newss = newsRep.getNews(true);
            
            return Json(newss,JsonRequestBehavior.AllowGet);
        }
    }
}