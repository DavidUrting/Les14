﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Les14.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult ARoomWithAView()
        {
            return View();
        }
    }
}