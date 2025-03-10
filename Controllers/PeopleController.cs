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
        // GET: People
        public ActionResult Index()
        {
            List<Students> members = new List<Students>
            {
                new Students { StudentID = "u24687473", Name = "Keshiv", Surname = "Gounden", StudentEmail = "u24687473@tuks.co.za", myLink = "~/HTML/Person01.html" },
                new Students { StudentID = "u23738929", Name = "Modiri", Surname = "Thobane", StudentEmail = "u23738929@tuks.co.za", myLink = "~/HTML/Person02.html" },
                new Students { StudentID = "u20417200", Name = "Naqeeb", Surname = "Hussain Dawood", StudentEmail = "u20417200@tuks.co.za", myLink = "~/HTML/Person03.html" },
                new Students { StudentID = "u24647323", Name = "Dian", Surname = "Erasmus", StudentEmail = "u24647323@tuks.co.za", myLink = "~/HTML/Person04.html" },
                new Students { StudentID = "u22578642", Name = "Nicola", Surname = "James", StudentEmail = "u22578642@tuks.co.za", myLink = "~/HTML/Person05.html" }
            };
            return View(members);
        }
    }
}