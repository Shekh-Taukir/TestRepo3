using DhartiMaaMvcCoreProject.Helper;
using DhartiMaaMvcCoreProject.Models;
using DhartiMaaMvcCoreProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (product == null)
            {
                return View();
            }
            var response = await _productRepository.AddProduct(product);
            if (response)
            {
                return RedirectToAction("Home/Index");
            }
            return View();
        }
    }
}
