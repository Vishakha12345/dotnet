using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace WebApplication1.Controllers
{
    public class showController : Controller
    {
        // GET: show
        public ActionResult Index()
        {
            List<Customer> l1 = Class1.GetAll();
            this.ViewData["products"] = l1;
            return View();
        }
    }
}