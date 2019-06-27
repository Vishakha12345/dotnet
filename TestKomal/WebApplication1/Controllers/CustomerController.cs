using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int id,String FirstName, String LastName,String Email,String city)
        {
            if(Class1.Insert(id,FirstName,LastName,Email,city))
            {
                return View();
            }
            return View();
        }

        private ActionResult Redirect(object p)
        {
            throw new NotImplementedException();
        }
    }
}