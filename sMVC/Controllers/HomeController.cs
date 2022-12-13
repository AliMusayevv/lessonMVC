
using sMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace sMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person one = new Person()
            {
                ID = 1,
                AD = "Ali"
            };
            Person two = new Person()
            {
                ID = 2,
                AD = "Xatire"
            };
            Person three = new Person()
            {
                ID = 3,
                AD = "Ismayil"
            };
            Person four = new Person()
            {
                ID = 4,
                AD = "Aslan"
            };
            Person five = new Person()
            {
                ID = 5,
                AD = "Omar"
            };
            ViewBag.Message = one;
            ViewBag.Message1 = two;
            ViewBag.Message2= three;
          ViewBag.Message3 = four;
            ViewBag.Message4 = five;


            return View();       


        }

        
    }
}