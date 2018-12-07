using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecureQuestionBankV0._1._3.Models;

namespace SecureQuestionBankV0._1._3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Register(FormCollection frm)
        {
            ViewBag.Message = "Your contact page.";
            string admintype = frm["AdminType"].ToString();

            return RedirectToAction(admintype);
            
        }
        [HttpGet]
        public ActionResult Sub_Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sub_Admin(SubAdmin SuA)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SubAdminRegHandleDb sarhdb = new SubAdminRegHandleDb();
                    if (sarhdb.AddSubAdmin(SuA))
                    {
                        ViewBag.Message = "Sub Admin Details Added Successfully";
                        ModelState.Clear();
                    }
                }
               return View();
            }
            catch
            {
                ViewBag.Message = "Sub Admin Details Added not Successfully";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(Admin Ad)
        {
              try
              {
            if (ModelState.IsValid)
            {
                AdminHandleRegDb sarhdb = new AdminHandleRegDb();
                if (sarhdb.AddAdmin(Ad))
                {
                    ViewBag.Message = " Admin Details Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
              }
             catch
             {
                 ViewBag.Message = "Admin Details Added not Successfully";
                 return View();
             }
        }

        [HttpGet]
        public ActionResult Super_Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Super_Admin(SuperAdmin SupAd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SuperAdminHandleRegDb suarhdb = new SuperAdminHandleRegDb();
                    if (suarhdb.AddSuperAdmin(SupAd))
                    {
                        ViewBag.Message = "Super Admin Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Super Admin Details Added not Successfully";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Centre_Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Centre_Admin(CentreAdmin CenA)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CentreAdminHandleDb cenrhdb = new CentreAdminHandleDb();
                    if (cenrhdb.AddCenterAdmin(CenA))
                    {
                        ViewBag.Message = "Centre Admin Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Centre Admin Details Added not Successfully";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*  [HttpPost]
          public ActionResult Login(LoginClass lc)
          {
              try
              {
                  if (ModelState.IsValid)
                  {
                      AdminLoginHandleDb alhdb = new AdminLoginHandleDb();
                      if (alhdb.SuperAdminLogin(lc)==true)
                      {

                          ViewBag.Message = " login  Successfully";
                          ModelState.Clear();
                          return RedirectToAction("TopNav", "SuperAdminTraffic");
                      }

                  }
                  // return View("TopNav", "SuperAdminTraffic");
                  // return RedirectToAction("TopNav", "SuperAdminTraffic");
                  return View();
              }
              catch
              {
                  ViewBag.Message = "Admin Details Added not Successfully";
                  return View();
              }

          }*/

        [HttpPost]
        public ActionResult Login(LoginClass lc)
        {


            AdminLoginHandleDb alhdb = new AdminLoginHandleDb();
            if (alhdb.SuperAdminLogin(lc) == true)
                 return RedirectToAction("TopNav", "SuperAdminTraffic");
            else if(alhdb.AdminLogin(lc) == true)
                return RedirectToAction("index", "AdminTraffic");
            else if (alhdb.SubAdminLogin(lc) == true)
                return RedirectToAction("index", "SubAdminTraffic");
            else if (alhdb.CentreAdminLogin(lc) == true)
                return RedirectToAction("index", "CentreAdminTraffic");
            else
                return View();

        }

    }
}