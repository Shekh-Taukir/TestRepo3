using DhartiMaaProject.Models;
using DhartiMaaProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        [Route("v1/product/add-product")]
        public async Task<IActionResult> AddProduct([FromBody]Product product)
        {
            if(product == null)
            {
                return Ok("Product can not be null");
            }
            return Ok(await productService.InsertProduct(product));
        }
    }
}
