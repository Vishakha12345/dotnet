using System.ComponentModel.DataAnnotations; 
// provides inbuilt annotations 
// data level constraints

namespace BOL
{
    //metdata
    //.net we use special attribute
    //annotations are associated with b. objects
    //data level constraints
    //Rules
    //Policies

    //POCO object

    public class Product
    {
       //data constraints

        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Range(10,25)]
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }

        [Required]  //attribute:
                    //applying member level constraint
        public string PaymentTerm { get; set; }
        public string DeliveryTerm { get; set; }
    }
}
