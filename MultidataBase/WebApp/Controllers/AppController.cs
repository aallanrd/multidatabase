using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using WebApp.ServiceReference1;
using WebApp.Models;

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
        public string CheckConnection(int a)
        {
            return client.checkConnection(a);
          
        }
        public ActionResult CrearTabla()
        {
           
            return View();
        }

        public ActionResult InsertarTabla()
        {
           
            return View();
        }

        public ActionResult ActualizarTabla()
        {
            return View();
        }

        public ActionResult BorrarTabla(int cID, string dbname, string table)
        {
            return View();
        }

        public ActionResult MultipleQuery()
        {
            return View();
        }
        public ActionResult BorrarDeTabla(int cID, string dbname, string table)
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
    

        public ActionResult CrearDB(String x)
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult CreateDB(string db_type, string db_name)
        {
           
            string x = client.createDatabase(db_type, db_name);
            return RedirectToAction("CrearDB", new { x = x });
           
          
        }


        public ActionResult IncluirDB(String x)
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult IncludeDB(string db_type, string user, string pass, string server, int port, string allias)
        {

            string x = client.includeDB(db_type, user, pass, server, port, allias);

            return RedirectToAction("IncluirDB", new { x = x });


        }

        
    }
}
