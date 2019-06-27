using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace WebApplication1.Controllers
{
    public class DeleteController : Controller
    {
        // GET: Delete
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            bool status = Class1.Delete(id);
            return View();
        }
    }
}