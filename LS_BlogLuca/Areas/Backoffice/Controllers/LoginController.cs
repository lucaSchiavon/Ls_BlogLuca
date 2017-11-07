using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LS_BlogLuca.Areas.Backoffice.Controllers
{
    public class LoginController : Controller
    {
        // GET: Backoffice/Login
        public ActionResult Index()
        {
            return View("Index","_LoginLayout");
        }
    }
}