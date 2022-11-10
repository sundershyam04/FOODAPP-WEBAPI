using FoodAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodAppWebAPI.Controllers
{
    public class FoodsController : ApiController
    {

        FoodDB context;
        public FoodsController()
        {
            context = new FoodDB();
        }

        // GET api/<controller>
        public IEnumerable<Foods> Get()
        {
            return context.FoodDetails.ToList();
        }

        // GET api/<controller>/5
        public Foods Get(int id)
        {
            var found = context.FoodDetails.ToList().Find(f => f.FoodId == id);
            return found;
        }

        // POST api/<controller>
        public void Post([FromBody] Foods f)
        {
            context.FoodDetails.Add(f);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Foods f)
        {
            var found = context.FoodDetails.ToList().Find(e => e.FoodId == id);
            context.FoodDetails.Remove(found);
            context.FoodDetails.Add(f);
            context.SaveChanges();

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var found = context.FoodDetails.ToList().Find(e => e.FoodId == id);
            context.FoodDetails.Remove(found);
            context.SaveChanges();

        }
    }
}