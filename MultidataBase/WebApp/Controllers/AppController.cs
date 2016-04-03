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
        public ActionResult CrearTabla()
        {
            // return client.includeDB("MariaDB", "root", "Ard2592allan", "localhost", 3306, "metadatadb");
            return View();
        }

        public ActionResult ActualizarTabla()
        {
            return View();
        }

        public ActionResult BorrarTabla()
        {
            return View();
        }

        public ActionResult MultipleQuery()
        {
            return View();
        }
        public ActionResult BorrarDeTabla()
        {
            return View();
        }
        // GET:     
        public ActionResult VerConexiones()
        {
            string x = client.getConnections();
            ViewBag.connections = x;
            return View();
        }
        public string checkMongo()
        {
           return  client.checkMongoConnection();
        }

        public string checkSQL()
        {
            return client.checkSQLConnection();
        }

        public ActionResult CrearDB(String x)
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult CreateDB(string db_type, string db_name)
        {
           
            string x = client.createDatabase(db_type, db_name);
            return RedirectToAction("CrearDB", new { x = "Creada" });
           
          
        }

        public ActionResult IncluirDB()
        {
            // return client.includeDB("MariaDB", "root", "Ard2592allan", "localhost", 3306, "metadatadb");
            return View();
        }
        
    }
}
