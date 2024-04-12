using Microsoft.AspNetCore.Mvc;

namespace Routing_Demo_MVC_Core_8.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Article()
        {
            return View();
        }
    }
}
