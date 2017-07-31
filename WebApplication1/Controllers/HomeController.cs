using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Countries =  new List<string>()
            {
                "India",
                "US",
                "UK"

            };
            return View();
        }

        public ViewResult Index2()
        {
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "UK"

            };
            return View();
        }







    }
}