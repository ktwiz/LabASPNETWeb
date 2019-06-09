using LabASPNETWeb.DataRepository;
using LabASPNETWeb.DataRepository.Linq;
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
        private INews newsRep = new LinqNewsRep();

        //! GET: Home
        public ActionResult Index()
        {
            //x AppStoreData.APP_LOGGER.Info("Enter: Home/Index");

            //! Load news in homepage
            List<wpNew> newss = newsRep.getNews(true);
            ViewBag.newss = newss;
            return View();
        }

        [HttpGet]
        [Route("Home/Detail/{id}")]
        public ActionResult Detail(int id)
        {
            wpNew n = newsRep.getNewsDetail(id);
            ViewBag.news = n;
            return View();
        }
    }
}