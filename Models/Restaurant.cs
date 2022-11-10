using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodAppWebAPI.Models
{
    public class Restaurant
    {
        [Required()]
        [Key]
        public int RestuarantId { get; set; }

        [Required()]
        [MaxLength(20, ErrorMessage = "Maximum 20 Characters only")]
        public string RestaurantName { get; set; }

        public string RestUrl { get; set; }

        public string City { get; set; }


    }
}