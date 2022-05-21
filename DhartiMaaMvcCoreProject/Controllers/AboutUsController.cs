using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class AboutUsController : Controller
    {
        [Route("about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
