using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareerSolutionsApp.Controllers
{
    public class WelcomeHomeController : Controller
    {
        // GET: WelcomeHome
        public ActionResult Welcome()
        {
            return View();
        }
       
    }
}