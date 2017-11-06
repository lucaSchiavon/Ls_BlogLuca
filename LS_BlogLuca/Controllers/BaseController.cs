using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LS_BlogLuca.Models;
using AQuestBaseProject.Utils;
using System.Web.Routing;
using System.IO;
using System.Globalization;
using System.Threading;

namespace LS_BlogLuca.Controllers
{
    public class BaseController : Controller
    {
        public string DefaultLangCode
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["CultureDefault"].ToString();
            }
        }

        public string CurrentLangCode
        {
            get;
            set;
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            CurrentLangCode =
                (requestContext.RouteData.Values["lang"] != null ?
                requestContext.RouteData.Values["lang"].ToString() :
                DefaultLangCode.Substring(0, 2));

            CulturesUtils.InitializeCurrentThreadCulture(CulturesUtils.LangCodeToCultureCode(CurrentLangCode));
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        protected string GetNativeNameFromLang(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(CulturesUtils.LangCodeToCultureCode(CurrentLangCode));
            var native = Thread.CurrentThread.CurrentCulture.NativeName;
            return native.Substring(0, 3);
        }
    }
}