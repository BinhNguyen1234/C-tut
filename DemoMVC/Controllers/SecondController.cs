using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoMVC.Controllers
{
	public class SecondController : Controller
	{



        public IActionResult Render()
        {
            return View();
        }
    }
}

