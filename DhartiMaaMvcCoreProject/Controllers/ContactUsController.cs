using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class ContactUsController : Controller
    {
        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
