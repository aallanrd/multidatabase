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
        public string Ver()
        {
           return  client.getConnections();
            //return new string{ "value1", "value2" };
        }

        public void IncludeDB()
        {
            string x = client.includeDB("MariaDB", "root", "Ard2592allan", "localhost", 3306, "jjxD2");
            //var name = this.Request.Form["txtName"];
            ViewBag.hello = x;
          
        }

        public string CreateDB()
        {
            return client.createDatabase("testingapp");
            
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: App/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: App/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: App/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
