using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        // GET:     
        public string[] Ver()
        {
            return new string[] { "value1", "value2" };
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
