using System;
using System.Collections.Generic;
using BOL;
namespace DAL
{
    public class Repository
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                ID = 1,
                Title = "Gerbera",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/Gerbera/cheerfuleight.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 2,
                Title = "Rose",
                Description = "Valentine flower",
                Likes = 7000,
                Quantity = 56000,
                UnitPrice = 20,
                Image = "/images/flowers/Rose/RedRose.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 3,
                Title = "Lily",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/gerbera.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 4,
                Title = "Carnation",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/gerbera.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 5,
                Title = "Marigold",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/gerbera.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 6,
                Title = "Lotus",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/gerbera.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            products.Add(new Product
            {
                ID = 7,
                Title = "Gerbera",
                Description = "Wedding flower",
                Likes = 5000,
                Quantity = 32000,
                UnitPrice = 10,
                Image = "/images/flowers/gerbera.jpg",
                DeliveryTerm = "1 Day after Order Confirmation",
                PaymentTerm = "50% advance with order confirmation and 50% before delivery"
            });
            return products;
        }
        public static List<Customer> GetAllCustomers()
        {

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { ID = 1, Name = "Nihilent", Email = "shiv.khera@nihilent.com", RegistrationDate = DateTime.Parse("9/2/2015"), isMVC = true, Location = "Mumbai", Membership = "Gold" });
            customers.Add(new Customer { ID = 2, Name = "IBM", Email = "sarang.sharma@ibm.com", RegistrationDate = DateTime.Parse("12/2/2016"), isMVC = false, Location = "Delhi", Membership = "Silver" });
            customers.Add(new Customer { ID = 3, Name = "Rational", Email = "patrik.s@rational.in", RegistrationDate = DateTime.Parse("8/3/2012"), isMVC = true, Location = "Mumbai", Membership = "Platinum" });
            customers.Add(new Customer { ID = 4, Name = "Mastercard", Email = "Kiran.patil@mastercard.com", RegistrationDate = DateTime.Parse("9/5/2014"), isMVC = true, Location = "Mumbai", Membership = "Gold" });
            customers.Add(new Customer { ID = 5, Name = "honeywell", Email = "meenal.sagade@honeywell.com", RegistrationDate = DateTime.Parse("9/7/2015"), isMVC = false, Location = "Mumbai", Membership = "Gold" });
            customers.Add(new Customer { ID = 6, Name = "jhonDeer", Email = "karan.varma@jhondeer.com", RegistrationDate = DateTime.Parse("11/8/2013"), isMVC = true, Location = "Pune", Membership = "Gold" });
            customers.Add(new Customer { ID = 7, Name = "Extentia", Email = "surabhi.nene@extentia.in", RegistrationDate = DateTime.Parse("12/10/2016"), isMVC = true, Location = "Chennai", Membership = "Gold" });
            customers.Add(new Customer { ID = 8, Name = "KloudWorks", Email = "sharayu.rane@kloudworks.in", RegistrationDate = DateTime.Parse("8/12/2014"), isMVC = true, Location = "Mumbai", Membership = "Silver" });
            return customers;
        }
        public static Customer GetCustomer(int id)
        {
            return new Customer
            {
                ID = 1,
                Name = "Nihilent",
                Email = "shiv.khera@nihilent.com",
                RegistrationDate = DateTime.Parse("9/2/2015"),
                isMVC = true,
                Location = "Mumbai",
                Membership = "Gold"
            };
        }
        public static bool Update(Customer customer)
        {
            return true;
        }
        public static bool Delete(Customer customer)
        {
            return true;
        }
        public static bool Insert(Customer customer)
        {
            return true;
        }
    }
}

