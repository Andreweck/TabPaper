using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Media;

namespace TabPaper.Controllers
{
    public class CompositionsController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult MusicPaper()
        {
            ViewBag.Title = "New Composition";
            ViewBag.range = "EBGDAEA";

            return View();
        }

        
    }
}