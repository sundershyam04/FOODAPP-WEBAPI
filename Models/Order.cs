using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAppWebAPI.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

        public int CustId { get; set; }

        public double TotalPrice { get;set; }

        // public virtual int? CustId { get; set; }

        //    [ForeignKey("CustId")]
        //    public virtual Customer cust { get; set; }
        //
    }
}