using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using AnB.Data.Articles.Models;
using AnB.Data.Articles.Services;
using AnB.Data.Articles.Context;
using AnB.Data.Ecommerce.Context;
using AnB.Data.Ecommerce.Models;
using AnB.Site.Models;

namespace AnB.Site.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //SiteDbContext dbcontext;
        //ArticlesContext articlesContext;
        EcommerceContext db;
        public ValuesController(EcommerceContext _db)
        {
            //dbcontext = _dbcontext;
            db = _db;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ProductCategory> Get()
        {
            //return _articlesServices.GetAll();
            var value = db.ProductCategory;
            return value;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
