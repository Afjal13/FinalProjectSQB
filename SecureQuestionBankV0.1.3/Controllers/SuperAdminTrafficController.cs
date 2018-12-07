using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecureQuestionBankV0._1._3.Models.SuperAdminModel;

namespace SecureQuestionBankV0._1._3.Models.SuperAdminModel.Controllers
{
    public class SuperAdminTrafficController : Controller
    {
        // GET: SuperAdminTraffic
        public ActionResult TopNav()
        {
          //  var nav = new SupANavbar();
            //return PartialView("topNav", nav.NavbarTop());
            return View();
            
        }
    }
}