﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Final.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}