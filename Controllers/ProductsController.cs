using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        // GET: api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[] { "Laptop", "Phone", "Tablet" });
        }

        // GET: api/products/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(new { Id = id, Name = "Laptop" });
        }

        // POST: api/products
        [HttpPost]
        public IActionResult Create([FromBody] string productName)
        {
            return Created("", new { Name = productName });
        }
    }
}
