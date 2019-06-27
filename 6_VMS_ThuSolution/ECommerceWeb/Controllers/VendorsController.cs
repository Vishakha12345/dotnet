using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWeb.Models;

namespace ECommerceWeb.Controllers
{
    public class VendorsController : Controller
    {
        // GET: Vendors
        public ActionResult Index()
        {
            Vendor vendor = new Vendor
            {
                ID = 34,
                Name = "IACSD",
                Email = "iacsd.pune@gamilc.com",
                Budget = 56000

            };

            return View(vendor);
        }
    }
}