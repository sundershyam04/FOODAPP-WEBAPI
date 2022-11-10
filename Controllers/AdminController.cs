using FoodAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodAppWebAPI.Controllers
{
    public class AdminController : ApiController
    {
        FoodDB context;
        public AdminController()
        {
            context = new FoodDB();
        }
        // GET api/<controller>
        public IEnumerable<Admin> Get()
        {
            return context.AdminDetails.ToList();
        }

        // GET api/<controller>/5
        public Admin Get(string id)
        {
           var found =  context.AdminDetails.ToList().Find(f => f.EmailId == id);
            return found;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}