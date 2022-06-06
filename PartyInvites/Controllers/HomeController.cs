﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()//Answer to every request
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?"صبح بخیر" : "عصر بخیر";
            return View();
        }

    }
}
