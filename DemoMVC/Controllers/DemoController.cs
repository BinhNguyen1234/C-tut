using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {

        public DemoController() => Console.WriteLine("Render");
        private List<string> TestModel = new List<string>()
        {
            "test1","test2","test3"
        };
        public ViewResult Render(int id, string name)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            return View("TestRender", TestModel);
        }
    }
}

