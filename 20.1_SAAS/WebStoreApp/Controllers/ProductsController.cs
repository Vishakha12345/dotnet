using System.Collections.Generic;
using System.Web.Http;

using BOL;
using DAL;
namespace WebStoreApp.Controllers
{
   public class ProductsController : ApiController
    {
        // GET: api/products
        public IEnumerable<Product> Get()
        {
            List<Product> allProducts = ProductDAL.GetAll();
            return allProducts;
        }

        // GET: api/products/5
        public Product Get(int id)
        {
            Product Product = ProductDAL.Get(id);
            return Product;
        }

        // POST: api/products
        public void Post([FromBody]Product product)
        {
            ProductDAL.Insert(product);
        }

        // PUT: api/products/5
        public void Put(int id, [FromBody]Product product)
        {
            ProductDAL.Update(product);
        }

        // DELETE: api/products/5
        public void Delete(int id)
        {
            Product Product = ProductDAL.Get(id);
            ProductDAL.Delete(id);
        }
    }
}