using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommWEbMonApp.Controllers
{
    public class MyCustomersController : Controller
    {
        // GET: MyCustomers
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyCustomers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyCustomers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyCustomers/Create
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

        // GET: MyCustomers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyCustomers/Edit/5
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

        // GET: MyCustomers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyCustomers/Delete/5
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
