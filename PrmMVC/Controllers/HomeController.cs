using PrmMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrmMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var person = new Person()
            //{
            //    id = 1,
            //    ad = "Xatire"
            //};

            var prsn=new List<Person>()
            { 
                new Person(){ad="Muxtar"},
                new Person(){ad="Ali"},
                new Person(){ad="Veli"},
                new Person(){ad="Semed"},
                new Person(){ad="Gulnar"}
            };
            Person p = new Person();
            p.persons = prsn;
            return View(p);
        }
        [Route("Home/GetId/{sehve}")]
        public ActionResult GetId(int sehve)
        {
           return Content("ID: "+ sehve);
        }
    }
}