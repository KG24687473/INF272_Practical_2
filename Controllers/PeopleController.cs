using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24687473_INF272_Practical_2.Models;

namespace u24687473_INF272_Practical_2.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            List<Person> people = new List<Person>
            {
                new Person { StudentNumber = 24687473, Name = "Keshiv", Surname = "Gounden", Email = "u24687473@tuks.co.za", myLink = Url.Content("~/Content/HTML/Person01.html") },
                new Person { StudentNumber = 23738929, Name = "Modiri", Surname = "Thobane", Email = "u23738929@tuks.co.za", myLink = Url.Content("~/Content/HTML/Person02.html") },
                new Person { StudentNumber = 20417200, Name = "Naqeeb", Surname = "Hussain Dawood", Email = "u20417200@tuks.co.za", myLink = Url.Content("~/Content/HTML/Person03.html") },
                new Person { StudentNumber = 24647323, Name = "Dian", Surname = "Erasmus", Email = "u24647323@tuks.co.za", myLink = Url.Content("~/Content/HTML/Person04.html") },
                new Person { StudentNumber = 22578642, Name = "Nicola", Surname = "James", Email = "u22578642@tuks.co.za", myLink = Url.Content("~/Content/HTML/Person05.html") }
            };

            return View(people);
        }
    }
}
