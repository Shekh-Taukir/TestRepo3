using Microsoft.AspNetCore.Mvc;

namespace DhartiMaaMvcCoreProject.Controllers
{
    public class BlogController : Controller
    {
        [Route("blogs")]
        public IActionResult Blogs()
        {
            return View();
        }

        [Route("blogs/{blogName?}")]
        public IActionResult BlogDetail(string blogName)
        {
            if (blogName != null)
                return View("~/Views/Blog/BlogPage.cshtml");
            else return View("~/Views/Blog/Blogs.cshtml");

        }
    }
}
