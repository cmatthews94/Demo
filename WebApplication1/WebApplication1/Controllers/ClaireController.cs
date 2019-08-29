using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoAppMVC.Interfaces;
using DemoAppMVC.Models;
using DemoAppMVC.ProgramLogic;

namespace DemoAppMVC.Controllers
{
    public class ClaireController : Controller
    {
        private readonly IWebLogic webLogic;

        public ClaireController(IWebLogic webLogic)
        {
            this.webLogic = webLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Readme()
        {
            string readme = "some readme";
            return View(readme);
        }

        public IActionResult GetName(int id)
        {
            if (id == 0)
            {
                return View(webLogic.GetClaire());
            }
            else if (id == 1)
            {
                return View(webLogic.GetMaria());
            }
            else
            {
                var error = new ErrorViewModel();
                return View(error);
            }

        }
    }
}