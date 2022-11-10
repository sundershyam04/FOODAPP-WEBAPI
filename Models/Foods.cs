using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAppWebAPI.Models
{
    public class Foods
    {

        [Required()]
        [Key]
        public int FoodId { get; set; }

        [Required()]
        public string FoodName { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        public int Qty { get; set; }    

        public string FoodUrl { get; set; } 

        public virtual int RestuarantId { get; set; }

        [ForeignKey("RestuarantId")]
        public virtual Restaurant Restaurant { get; set; }

    }
}