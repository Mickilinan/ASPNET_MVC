﻿using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
