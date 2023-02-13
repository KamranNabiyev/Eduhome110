using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
