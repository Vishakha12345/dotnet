using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{

    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {

            List<string> videogames = new List<string>
                                    {
                                        "Starcraft",
                                        "Halo",
                                        "Legend of Zelda"
                                    };

            string json = JsonConvert.SerializeObject(videogames);

            Console.WriteLine(json);





            List<Product> products = new List<Product>();
            products.Add(new Product { ID = 1, Title = "Gerbera", UnitPrice = 34, Quantity = 450 });
            products.Add(new Product { ID = 2, Title = "Rose", UnitPrice = 12, Quantity = 450 });
            products.Add(new Product { ID = 3, Title = "Lotus", UnitPrice = 45, Quantity = 450 });
            products.Add(new Product { ID = 4, Title = "Lily", UnitPrice = 32, Quantity = 450 });

            string jsonProducts = JsonConvert.SerializeObject(products);
           
            Console.WriteLine(jsonProducts);

            Console.ReadLine();

        }
    }
}
