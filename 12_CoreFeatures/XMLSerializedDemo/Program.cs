using System;
using System.Xml.Serialization;

namespace XMLSerializedDemo
{
  public class Program
    {
        public static void Main()
        {
            XmlSerializer serialization = new XmlSerializer(typeof(Product));

            Product car1 = new Product("BMW", 1, 10000000);
            Product car2 = new Product("BMW", 1, 10000000);
            Product car3 = new Product("BMW", 1, 10000000);

           

            serialization.Serialize(Console.Out, car1);
            serialization.Serialize(Console.Out, car2);
            serialization.Serialize(Console.Out, car3);
            Console.ReadLine();

        }
    }

    public class Product
    {

        [XmlElementAttribute("Name")]
        public string name;
        [XmlAttributeAttribute("Quantity")]
        public int quantity;
        [XmlAttributeAttribute("Price")]
        public int price;

        public Product()
        {
        }

        public Product(string name, int quantity, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }

}