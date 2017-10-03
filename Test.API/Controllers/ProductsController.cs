using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.API.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {

        private ProductsRepo _repo;

        public ProductsController(ProductsDB db)
        {
            _repo = new ProductsRepo(db);
        }

        // GET: api/products
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_repo.GetAll());
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
