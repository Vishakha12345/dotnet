using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace WebApplication1.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public ActionResult update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult update(int id, string FirstName, string Email, string city)
        {
            Boolean q1 =Class1.Upadate(id,  FirstName,  Email,  city);
            return View();
        }
    }
}