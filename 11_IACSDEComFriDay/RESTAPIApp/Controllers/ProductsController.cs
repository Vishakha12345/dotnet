using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BOL;
using BLL;

namespace RESTAPIApp.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            IEnumerable<Product> allProducts = ProductManager.GetAll();
            return allProducts;
        }


        public Product Get(int id)
        {
            Product Product = ProductManager.Get(id);
            return Product;
        }
    }
}
