using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace BOL
{
   public  class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        [CustomEmailValidator]
        public string Email { get; set; }
        [Range(19,59,ErrorMessage ="Employee Age shuld be in between 10 to 59")]
        public int Age { get; set; }
    }
}
