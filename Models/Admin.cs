using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FoodAppWebAPI.Models
{
    public class Admin
    {

        [Required()]
        [EmailAddress]
        [Key]
        public string EmailId { get; set; }
        [PasswordPropertyText]
        [Required()]
        public string Password { get; set; }

    }
}