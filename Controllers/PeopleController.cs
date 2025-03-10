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
        private static List<Students> GetPeopleList()
        {
            return new List<Students>
            {
                new Students { StudentID = "u24687233", Name = "Keshiv", Surname = "Gounden", StudentEmail = "u24687233@tuks.co.za", myLink = "~/HTML/Keshiv.html" },
                new Students { StudentID = "u23738929", Name = "Modiri", Surname = "Thobane", StudentEmail = "u23738929@tuks.co.za", myLink = "~/HTML/Modiri.html" },
                new Students { StudentID = "u20417200", Name = "Naqeeb", Surname = "Hussain Dawood", StudentEmail = "u20417200@tuks.co.za", myLink = "~/HTML/Naqeeb.html" },
                new Students { StudentID = "u24647323", Name = "Dian", Surname = "Erasmus", StudentEmail = "u24647323@tuks.co.za", myLink = "~/HTML/Dian.html" },
                new Students { StudentID = "u22578642", Name = "Nicola", Surname = "James", StudentEmail = "u22578642@tuks.co.za", myLink = "~/HTML/Nicola.html" }
            };
        }

        public ActionResult Index()
        {
            var members = GetPeopleList();
            return View(members);
        }
    }
}