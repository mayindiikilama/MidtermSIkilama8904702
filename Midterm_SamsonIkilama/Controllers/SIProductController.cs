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
        n

    }
}
