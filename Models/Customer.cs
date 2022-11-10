using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodAppWebAPI.Models
{
    public class Customer
    {
            [Key]
            [Required]
            public int CustId { get; set; }
            [Required()]
            [MaxLength(20, ErrorMessage = "Maximum 20 Characters only")]
            public string FirstName { get; set; }
            [Required()]
            [MaxLength(20, ErrorMessage = "Maximum 20 Characters only")]
            public string LastName { get; set; }
            [Required()]
            [MaxLength(20, ErrorMessage = "Maximum 20 Characters only")]
            public string Email { get; set; }
            [Required()]
            public int PhoneNumber { get; set; }

            [PasswordPropertyText]
            [Required()]
            public string Password { get; set; }
            [PasswordPropertyText]
            [Required()]
            public string ConfirmPassword { get; set; }

            [Required()]
            [MaxLength(40, ErrorMessage = "Maximum 40 Characters only")]
            public string Address { get; set; }

            public virtual ICollection<Order> Orders { get; set; }

    }
}

