using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI.WebControls.WebParts;

namespace FoodAppWebAPI.Models
{
    public class FoodDB : DbContext
    {
        // Your context has been configured to use a 'FoodDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FoodAppWebAPI.Models.FoodDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FoodDB' 
        // connection string in the application configuration file.
        public FoodDB()
            : base("name=FoodDB")
        {
            Database.SetInitializer<FoodDB>(new DropCreateDatabaseIfModelChanges<FoodDB>());
        }

        public virtual DbSet<Admin> AdminDetails { get; set; }
        public virtual DbSet<Customer> CustomerDetails { get; set; }

        public virtual DbSet<Order> OrderDetails { get; set; }

        public virtual DbSet<Restaurant> RestaurantDetails { get; set; }

        public virtual DbSet<Foods> FoodDetails { get; set; }

        

    }

   
}