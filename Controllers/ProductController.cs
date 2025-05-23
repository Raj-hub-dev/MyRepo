using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebapiAPP1.Controllers
{
    public class ProductController : ApiController
    {
        static List<string> products = new List<string> { "Laptop", "Tablet", "Phone" };

        [HttpGet]
        [Route("api/products")]
        public IEnumerable<string> Get() => products;

        //[HttpGet]
        //[Route("api/products/{id}")]
        //public IEnumerable<string> GetProducts(int id)
        //{
        //    if (id < 0 || id > products.Count)
        //        return NotFound();
        //    return Ok(products[id]);
        //}

        [HttpPost]
        [Route("api/products")]
        public IHttpActionResult Post([FromBody] string product)
        {
            products.Add(product);
            return Ok(products);
        }

        [HttpDelete]
        [Route("api/products/{id}")]
        public IHttpActionResult Delete(int id)
        {
            if (id < 0 || id >= products.Count) return NotFound();
            products.RemoveAt(id);
            return Ok(products);
        }
    }
}
