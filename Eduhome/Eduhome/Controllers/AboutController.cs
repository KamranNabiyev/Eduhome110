using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
