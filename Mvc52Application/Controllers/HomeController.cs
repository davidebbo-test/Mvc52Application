using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCoolLib;

namespace Mvc52Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("{0}: This is an informational trace message", DateTime.Now);
            Trace.TraceWarning("{0}: Here is trace warning", DateTime.Now);
            Trace.TraceError("{0}: Something is broken; tracing an error!", DateTime.Now);
            Trace.TraceInformation("123&quot;456\"789");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = $"SayHello: {Hello.SayHello("David")}, Foo Appsetting: {ConfigurationManager.AppSettings["foo"]}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}