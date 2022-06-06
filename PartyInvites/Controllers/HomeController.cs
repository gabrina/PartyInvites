using System;
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
            ViewBag.Greeting = hour < 12 ?"Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        public ViewResult MyView()//Answer to every request
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ViewResult RsvpFrom()
        {
            return View();
            //no argument: telling MVC to show the default view having same name with this action
            //In this case, RsvpFrom.cshtml
        }
    }
}
