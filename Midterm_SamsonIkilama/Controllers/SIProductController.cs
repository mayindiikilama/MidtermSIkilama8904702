using Microsoft.AspNetCore.Mvc;
using Midterm_SamsonIkilama.Model;

namespace Midterm_SamsonIkilama.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SIProductController : ControllerBase
    {
        private readonly SIProductService _productService;

        public SIProductController(SIProductService productService)
        {
            _productService = productService;
        }

        // GET: api/SIProduct
        [HttpGet]
        public ActionResult<List<SIProduct>> GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }


        // POST: api/SIProduct
        [HttpPost]
        public IActionResult Post([FromBody] SIProduct product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    error = "InvalidProduct",
                    message = "Name cannot be empty"
                });
            }

            var created = _productService.Add(product);

            return Created("", new
            {
                message = "Product created",
                Product = created
            });
        }
    }
}


