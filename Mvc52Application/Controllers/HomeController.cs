using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc52Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("{0}: This is an informational trace message", DateTime.Now);
            Trace.TraceWarning("{0}: Here is trace warning", DateTime.Now);
            Trace.TraceError("{0}: Something is broken; tracing an error!", DateTime.Now);

            return View();
        }

        public ActionResult About()
        {
            string foo = ConfigurationManager.AppSettings["foo"];
            ViewBag.Message = String.Format("The value of setting foo is: '{0}'", foo);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}