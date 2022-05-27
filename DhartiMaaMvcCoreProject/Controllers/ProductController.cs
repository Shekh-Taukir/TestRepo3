using DhartiMaaMvcCoreProject.Helper;
using DhartiMaaMvcCoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class ProductController : Controller
    {
        DhartiMaaAPI _api = new DhartiMaaAPI();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult addProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            HttpClient client = _api.Initial();

            var postTask=client.PostAsJsonAsync<Product>("api/Product/v1/product/add-product",product);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
    }
}
