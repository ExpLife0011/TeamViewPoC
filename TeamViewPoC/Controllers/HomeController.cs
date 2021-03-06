﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamViewPoC.Models;

namespace TeamViewPoC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //send to the today page
            return RedirectToAction("Today", "Workitem");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
