﻿using Microsoft.AspNetCore.Mvc;

namespace Eduhome.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
