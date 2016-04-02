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
            string x = client.includeDB("MariaDB", "root", "Ard2592allan","localhost", 3306, "jjxD2");
            var name = this.Request.Form["txtName"];
            ViewBag.hello = x;
            return View();
        }
      
    }
}
