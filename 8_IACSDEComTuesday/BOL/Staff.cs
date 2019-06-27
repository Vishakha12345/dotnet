using System.ComponentModel.DataAnnotations;
//using CustomValidators;
namespace BOL
{
    public class Staff
    {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Range(18, 56)]
            public int Age { get; set; }

           // [CustomEmailValidator]
            public string Email { get; set; }
     
    }
}
