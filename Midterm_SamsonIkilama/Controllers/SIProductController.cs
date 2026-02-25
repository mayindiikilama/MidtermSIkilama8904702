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
        public ActionResult<SIProduct> Add(SIProduct product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addedProduct = _productService.Add(product);
            return CreatedAtAction(nameof(GetAll), new { id = addedProduct.Id }, addedProduct);
        }

    }
}
