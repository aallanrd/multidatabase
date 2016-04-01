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
            string x = client.includeDB("MariaDB", "root", "Ard2592allan", 3306, "metadatadb");
            ViewBag.hello = x;
            return View();
        }
    }
}
