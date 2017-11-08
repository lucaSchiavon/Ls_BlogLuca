using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LS_BlogLuca.EF;
using LS_BlogLuca.Models.Backoffice;

namespace LS_BlogLuca.Areas.Backoffice.Controllers
{
    public class LoginController : Controller
    {
        // GET: Backoffice/Login
        public ActionResult Index()
        {
            var ObjUtenteDto = new UtenteViewModel();

            return View("Index","_LoginLayout", ObjUtenteDto);
        }

        [HttpPost]
        public ActionResult Authorize(LS_BlogLuca.Models.Backoffice.UtenteViewModel ObjUtenteDto)
        {
            
            using (ModelLucaBlog db = new ModelLucaBlog())
            {
                var userDetalis = db.Utenti.Where(x => x.Username == ObjUtenteDto.Username && x.Password == ObjUtenteDto.Password).ToList();
                if (userDetalis.Count == 0)
                {
                    ObjUtenteDto.ErrorMessage = "Utente non riconosciuto";
                    return View("Index", "_LoginLayout",ObjUtenteDto);
                }
                else
                {
                    Session["UserId"] = userDetalis.FirstOrDefault().IdUtente;
                    return RedirectToAction("Index","Home");
                }
            }
                return View();
        }
    }
}