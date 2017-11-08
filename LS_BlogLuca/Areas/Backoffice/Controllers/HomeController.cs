using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LS_BlogLuca.Areas.Backoffice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Backoffice/Login
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }

           
        }

        public ActionResult LogOut()
        {
            Session["UserId"] = null;
            return RedirectToAction("Index", "Login");
           
        }
    }
}