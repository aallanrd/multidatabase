using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.ServiceReference1;

namespace WebApp.Controllers
{
    public class AppController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        // GET:     
        public ActionResult VerConexiones()
        {
            //return  client.getConnections();
            return View();
        }


        public ActionResult CrearDB()
        {
            //return client.createDatabase("testingapp");
            return View();
        }

        public ActionResult IncluirDB()
        {
            // return client.includeDB("MariaDB", "root", "Ard2592allan", "localhost", 3306, "metadatadb");
            return View();
        }
        public ActionResult InsertarTabla()
        {
            // return client.includeDB("MariaDB", "root", "Ard2592allan", "localhost", 3306, "metadatadb");
            return View();
        }

    }
}
