﻿using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
