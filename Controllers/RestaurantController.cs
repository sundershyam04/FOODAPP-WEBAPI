using FoodAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodAppWebAPI.Controllers
{
    public class RestaurantController : ApiController
    {
        FoodDB context;
        public RestaurantController()
        {
            context = new FoodDB();
        }
        // GET api/<controller>
        public IEnumerable<Restaurant> Get()
        {
            return context.RestaurantDetails.ToList();
        }

        // GET api/<controller>/5
        public Restaurant Get(int id)
        {
            var found = context.RestaurantDetails.ToList().Find(f => f.RestuarantId == id);
            return found;
        }

        // POST api/<controller>
        public void Post([FromBody] Restaurant c)
        {
            context.RestaurantDetails.Add(c);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Restaurant c)
        {
            var found = context.RestaurantDetails.ToList().Find(f => f.RestuarantId == id);
            context.RestaurantDetails.Remove(found);
            context.RestaurantDetails.Add(c);
            context.SaveChanges();

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var found = context.RestaurantDetails.ToList().Find(f => f.RestuarantId == id);
            context.RestaurantDetails.Remove(found);
            context.SaveChanges();
        }
    }
}