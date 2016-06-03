using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tester.Controllers
{
    public class HomeController : Controller
    {
        /** http://localhost:62113/ **/

        public string Index()
        {
            return "Hello World";
        }

        /**public ActionResult Index()
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
        }**/
    }
}