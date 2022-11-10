using FoodAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodAppWebAPI.Controllers
{
    public class CustomerController : ApiController
    {

        FoodDB context;
        public CustomerController()
        {
            context = new FoodDB();
        }
        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            return context.CustomerDetails.ToList();
        }

        // GET api/<controller>/5
        public Customer Get(int id)
        {
            var found = context.CustomerDetails.ToList().Find(f => f.CustId == id);
            return found;
        }

        // POST api/<controller>
        public void Post([FromBody] Customer c)
        {
            context.CustomerDetails.Add(c);
            context.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Customer c)
        {
            var found = context.CustomerDetails.ToList().Find(f => f.CustId == id);
            context.CustomerDetails.Remove(found);
            context.CustomerDetails.Add(c);
            context.SaveChanges();

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var found = context.CustomerDetails.ToList().Find(f => f.CustId == id);
            context.CustomerDetails.Remove(found);
            context.SaveChanges();
        }
    }
}