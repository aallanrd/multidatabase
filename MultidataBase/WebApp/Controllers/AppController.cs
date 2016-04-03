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

        public ActionResult CrearDB()
        {
            return View();
        }

        [HttpPost]
        public string CreateDB(string db_type, string db_name)
        {
           // DB db = new DB(1,db_type,db_name);
            
            //get Data from HTML
            return client.createDatabase(db_type, db_name);
           // return RedirectToAction("Index");
           
          
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
