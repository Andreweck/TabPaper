using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Media;
using System.Collections;
using TabPaper.ViewModels;
using Newtonsoft.Json;
using TabPaper.Data;

namespace TabPaper.Controllers
{
    public class CompositionsController : Controller
    {
        public static TabViewModel model = new TabViewModel();
        public List<string> TVM= model.Jobs;
        public int ID = 0;

        public static void Add()
        {
            model.Jobs.Add("This works");
        }

        public ActionResult Index()
        {
           
            ViewBag.values = TVM;
            

            return View();
        }

       
            
        public ActionResult MusicPaper()
        {
            ViewBag.Title = "New Composition";
            ViewBag.range = "EBGDAEA";
            ViewBag.apnd = TVM;
            TabViewModel modell = model;
           
            return View(modell);
        }

        [HttpPost]

        public ActionResult MusicPaper(TabViewModel modell)
        {
            string values;
            ViewBag.Title = "New Composition";
            ViewBag.range = "EBGDAEA";
            
            TabViewModel msc = new TabViewModel();
            return View(msc);
        }
    }
}