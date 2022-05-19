using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class ServiceController : Controller
    {
        [Route("service")]
        public IActionResult Service()
        {
            return View();
        }
    }
}
