using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ECommerceWeb.Models
{
    public class Vendor
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Range(minimum:50000, maximum:500000)]
        public double Budget { get; set; }
    }
}