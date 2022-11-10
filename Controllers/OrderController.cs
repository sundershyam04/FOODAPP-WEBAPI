using FoodAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodAppWebAPI.Controllers
{
    public class OrderController : ApiController
    {

        FoodDB context;
        public OrderController()
        {
            context = new FoodDB();
        }
        // GET api/<controller>
        public IEnumerable<Order> Get()
        {
            return context.OrderDetails.ToList();
        }

        // GET api/<controller>/5
        public Order Get(int id)
        {
            var found = context.OrderDetails.ToList().Find(f => f.OrderId == id);
            return found;
        }

        // POST api/<controller>
        public void Post([FromBody] Order o)
        {
            context.OrderDetails.Add(o);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Order o)
        {
            var found = context.OrderDetails.ToList().Find(f => f.OrderId == id);
            context.OrderDetails.Remove(found);
            context.OrderDetails.Add(o);
            context.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var found = context.OrderDetails.ToList().Find(f => f.OrderId == id);
            context.OrderDetails.Remove(found);
            context.SaveChanges();
        }
    }
}