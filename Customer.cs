using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Customer
    {

            [Key]
            [Required]
            public int CustomerId { get; set; }
            [Required]
            public string CustomerName { get; set; }
            [Required]
            public string City { get; set; }
            [Range(1, 100)]
            public int Age { get; set; }
            [Required]
            [Range(0000000001, 9999999999)]
            public decimal PhoneNumber { get; set; }
            [Required]
            public int Pincode { get; set; }
        
    }
}
