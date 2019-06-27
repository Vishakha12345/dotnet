using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;
namespace EComWFE.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = (List<Product>)this.HttpContext.Application["products"];
            this.ViewData["products"] = products;
            return View();
        }

        public ActionResult Details(int id)
        {
            Product foundProduct = null;
            List<Product> products = (List<Product>)this.HttpContext.Application["products"];
            foreach (Product product in products)
            {
                if (product.ID == id)
                {
                    foundProduct = product;
                    break;
                }
            }

            return View(foundProduct);
        }
    }
}