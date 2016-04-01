using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.ServiceReference1;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        Service1Client client = new Service1Client();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            client.includeDB();
            return View();
        }
    }
}
