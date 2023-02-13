using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
