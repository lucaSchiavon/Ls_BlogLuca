using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LS_BlogLuca.Models;
using LS_BlogLuca.Models.Contact;

namespace LS_BlogLuca.Controllers
{
    public class ContactController : BaseController
    {

        public ActionResult Index()
        {

            var Vm = new IndexViewModel();
            Vm.CurrentLangCode = CurrentLangCode;

            Vm.HeaderVM = new HeaderViewModel();
            Vm.HeaderVM.CurrentLangCode = CurrentLangCode;

            Vm.NavigationVM = new NavigationViewModel();
            Vm.NavigationVM.CurrentLangCode = CurrentLangCode;

            Vm.FooterVM = new FooterViewModel();
            Vm.FooterVM.CurrentLangCode = CurrentLangCode;

            return View(Vm);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}