﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicaton.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
