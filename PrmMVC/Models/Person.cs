using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrmMVC.Models
{
    public class Person
    {
        public int id { get; set; }
        public string ad { get; set; }

        public List<Person> persons { get; set;}
    }
}