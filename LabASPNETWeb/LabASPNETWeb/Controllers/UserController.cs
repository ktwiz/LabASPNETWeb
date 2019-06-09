using LabASPNETWeb.DataRepository;
using LabASPNETWeb.DataRepository.Linq;
using LabASPNETWeb.Models.Form;
using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabASPNETWeb.Controllers
{
    public class UserController : Controller
    {
        private IUser userRep = new LinqUserRep();  
        

        //? Do cheat only with this route
        //? NOT WORKING -- CHECKING ROUTE
        [HttpGet]
        [Route("User/Cheat/{username}/{password}")]
        public ActionResult cheatUpdatePassword(string username,string password)
        {
            userRep.encrytSavePassword(username, password);
            return RedirectToAction("Index", "Home");
        }

        // GET: User
        [HttpGet]
        [ChildActionOnly]
        public ActionResult Login()
        {
            LoginForm form = new LoginForm();
            //todo: Check session user existed or not ?
            string ss_username = (string) Session[AppStoreData.PAR.USR_LOG];
            wpUser userLogin = null;
            bool isLoggedIn = false;
            if(ss_username != null)
            {
                //todo: Logged in
                userLogin = userRep.getUser(ss_username);
                isLoggedIn = true;
            }

            //todo: need to enhance less code
            //todo: put userlogin to model to display?
            if (!isLoggedIn)
            {
                ViewBag.MGS_AUTHFAIL_VAL = TempData[AppStoreData.PAR.MGS_AUTHFAIL];
                return PartialView("LoginFormPartial", form);
            }
            else
            {
                ViewBag.userlogin = userLogin;
                return PartialView("UserInformationPartial", form);
            }            
            
        }

        [HttpPost]        
        public ActionResult Login(LoginForm form)
        {
            bool isAuthen = userRep.authenticateUser(form.Username, form.Password);
            wpUser user = null;
            if (isAuthen)
            {
                //todo: Do login stuff
                user = userRep.getUser(form.Username);
                userRep.saveLastLogin(form.Username);
                Session[AppStoreData.PAR.USR_LOG] = form.Username;
            }
            else
            {
                TempData[AppStoreData.PAR.MGS_AUTHFAIL] = AppStoreData.PAR.MGS_AUTHFAIL_VAL;
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            string ss_username = (string)Session[AppStoreData.PAR.USR_LOG];
            if (ss_username != null)
            {
                Session.Clear();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}