using System;
using System.Collections.Generic;
 
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BOL;
using Newtonsoft.Json;



//System.Net.Http.Formatting.dll

namespace WebSiteEStoreManaged.Controllers
{
    public class ProductsController : Controller
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost:17175/api/products";

        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public ProductsController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: EmployeeInfo
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var products = JsonConvert.DeserializeObject<List<Product>>(responseData);

                return View(products);
            }
            return View("Error");
        }



        public async Task<ActionResult> Detail(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                //  var Employee = JsonConvert.DeserializeObject<Product>(responseData);
                var product = JsonConvert.DeserializeObject<Product>(responseData);
                return View(product);
            }
            return View("Error");
        }
        public ActionResult Create()
        {
            return View(new Product());
        }

        //The Post method
        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url, product);
            // HttpResponseMessage responseMessage = await client.PostAsync(url, Emp);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

              //  var Employee = JsonConvert.DeserializeObject<Product>(responseData);
                var product = JsonConvert.DeserializeObject<Product>(responseData);
                return View(product);
            }
            return View("Error");
        }

        //The PUT Method
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Product product)
        {

            product.CategoryInfo = new Category() { Title = "Mobile", CategoryId = 1 };

            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + "/" + id, product);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var product = JsonConvert.DeserializeObject<Product>(responseData);

                return View(product);
            }
            return View("Error");
        }

        //The DELETE method
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Product product)
        {

            HttpResponseMessage responseMessage = await client.DeleteAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
    }
}