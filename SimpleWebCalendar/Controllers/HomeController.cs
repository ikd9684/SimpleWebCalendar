using SimpleWebCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebCalendar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string year, string month)
        {
            CalendarViewModel vm;

            int y = 0;
            int m = 0;
            if (int.TryParse(year, out y) && int.TryParse(month, out m))
            {
                vm = new CalendarViewModel(y, m);
            }
            else
            {
                vm = new CalendarViewModel(DateTime.Now.Year, DateTime.Now.Month);
            }

            return View(vm);
        }
    }
}
