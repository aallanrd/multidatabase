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
        public ActionResult CrearTabla()
        {
            return View();
        }

        [HttpPost]
        public JsonResult HttpCreateTable(int cID, string name,string columns)
        {

            CreateTableVM t = new CreateTableVM(cID, name, columns);
            var jsonCT = JsonConvert.SerializeObject(t); 
            string x = client.createTable(jsonCT);
            client.Close();
            return new JsonResult { Data = x};

        }

        // App Insertar Valores en Tabla
        public ActionResult InsertarTabla( )
        {
            return View();
        }


        [HttpPost]
        public JsonResult HttpInsertValueTable(int cID, string table_name, string values)
        {
            ITable t = new ITable(cID, table_name, values);
            var jsonIVT = JsonConvert.SerializeObject(t);
            //db_type, db_name
            string x = client.insertValuesTable(jsonIVT);
            return new JsonResult { Data = x };

        }

        //Actualizar valores de tabla
        public ActionResult ActualizarTabla()
        {
          
            return View();
        }


        [HttpPost]
        public JsonResult HttpUpdateTable(int cID, string table_name, string values)
        {
            UpdateTableVM t = new UpdateTableVM(cID, table_name, values);
            var jsonAVT = JsonConvert.SerializeObject(t);
            //db_type, db_name
            string x = client.deleteTable(jsonAVT);
            return new JsonResult { Data = x };

        }

        //Borrar Datos de Tabla
        public ActionResult BorrarTabla()
        {
            return View();
        }


        [HttpPost]
        public JsonResult HttpDeleteTable(int cID, string table_name)
        {

            DTable t = new DTable(cID, table_name);
            var jsonDT = JsonConvert.SerializeObject(t);
            //db_type, db_name
            string x = client.deleteTable(jsonDT);
            return new JsonResult { Data = x };

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
        public ActionResult HttpCreateDB(int cID, string db_name)
        {

            DatabaseViewModel dbV = new DatabaseViewModel(cID, db_name);
            var jsonCDB = JsonConvert.SerializeObject(dbV);
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
        public ActionResult HttpIncludeDB(string db_type,string username,string pass,string server,string protocol,int port,string alias)
        {

            IncludeDbVm dbV = new IncludeDbVm(db_type, username, pass, server, protocol, port, alias);
            var jsonIDB = JsonConvert.SerializeObject(dbV);
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
