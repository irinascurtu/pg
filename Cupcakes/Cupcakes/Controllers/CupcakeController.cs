using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cupcakes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcakes.Controllers
{
    public class CupcakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
           // PopulateBakeriesDropDownList();
            return View();
        }


    }
}