using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
