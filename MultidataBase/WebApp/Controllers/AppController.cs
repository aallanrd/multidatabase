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

        // CLiente del Servicio Web 
        Service1Client client = new Service1Client();

        // Index : Retorna vista de seleccion de funciónes.
        public ActionResult Index()
        {
            return View();
        }


        //  App/CrearTabla

        public ActionResult CrearTabla(string x)
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult HttpCreateTable(string jsonCT)
        {
          
            string x = client.createTable(jsonCT);
            return RedirectToAction("CrearTabla", new { x = x });

        }

        public ActionResult InsertarTabla(string x)
        {
            ViewBag.inserted = x;
            return View();
        }


        [HttpPost]
        public ActionResult HttpInsertValueTable(string jsonIVT)
        {
            //db_type, db_name
            string x = client.insertValuesTable(jsonIVT);
            return RedirectToAction("InsertarTabla", new { x = x });

        }

        public ActionResult ActualizarTabla(string x)
        {
            ViewBag.updated = x;
            return View();
        }


        [HttpPost]
        public ActionResult HttpUpdateTable(string jsonDT)
        {
            //db_type, db_name
            string x = client.deleteTable(jsonDT);
            return RedirectToAction("ActualizarTabla", new { x = x });

        }

        public ActionResult BorrarTabla(string x)
        {
            ViewBag.deleted = x;
            return View();
        }


        [HttpPost]
        public ActionResult HttpDeleteTable(string jsonDT)
        {
            //db_type, db_name
            string x = client.deleteTable(jsonDT);
            return RedirectToAction("BorrarTabla", new { x = x });

        }

        public ActionResult MultipleQuery(string x)
        {
            ViewBag.multiple = x;
            return View();
        }

        [HttpPost]
        public ActionResult HttpMultipleQuery(string jsonMQ)
        {
            //db_type, db_name
            string x = client.multipleQuery(jsonMQ);
            return RedirectToAction("MultipleQuery", new { x = x });

        }


        public ActionResult BorrarDeTabla(string x)
        {
            ViewBag.deleted = x;
            return View();
        }

        [HttpPost]
        public ActionResult HttpDeleteValueTable(string jsonDVT)
        {
            //db_type, db_name
            string x = client.deleteValuesTable(jsonDVT);
            return RedirectToAction("BorrarDeTabla", new { x = x });

        }

    
        public ActionResult CrearDB(string x)
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult HttpCreateDB(string jsonCDB)
        {
            //db_type, db_name
            string x = client.createDatabase(jsonCDB);
            return RedirectToAction("CrearDB", new { x = x });
           
          
        }


        public ActionResult IncluirDB(string x )
        {
            ViewBag.created = x;
            return View();
        }

        [HttpPost]
        public ActionResult HttpIncludeDB(string db_type, string user, string pass, string server, int port, string allias)
        {

            DBViewModel model = new DBViewModel(db_type, user, pass, server, "tcp/ip", port, allias);
            var jsonIDB = JsonConvert.SerializeObject(model);
            string x = client.includeDB(jsonIDB);

            return RedirectToAction("IncluirDB", new { x = x });


        }

        // GET:     
        public ActionResult VerConexiones()
        {
            string x = client.getConnections();

            ViewBag.connections = x;


            return View();
        }


        // App/CheckConnection?a=1
        // Chequea una conexion especifica por ID 
        public string CheckConnection(int a)
        {
            return client.checkConnection(a);

        }


    }
}
