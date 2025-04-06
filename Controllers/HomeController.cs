using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24687473_INF272_Practical_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Person1()
        {
           
            return Redirect("~/Content/HTML/Person01.html");
        }

        public ActionResult Person2()
        {
            return Redirect("~/HTML/Person2.html");
        }

        public ActionResult Person3()
        {
            return Redirect("~/HTML/Person3.html");
        }

        public ActionResult Person4()
        {
            return Redirect("~/HTML/Person4.html");
        }

        public ActionResult Person5()
        {
            return Redirect("~/HTML/Person5.html");
        }
    }
}