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
        public List<string> TVM;

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

        public ActionResult MusicPaper(int data)
        {
            string values;
            ViewBag.Title = "New Composition";
            ViewBag.range = "EBGDAEA";
            
            TabViewModel msc = new TabViewModel();
            return View(msc);
        }

        public ActionResult LoadMusicPaper(int id, int page)
        {
            
            ViewBag.Title = "New Composition";
            ViewBag.range = "EBGDAEA";
            ViewBag.idnum = id;
            ViewBag.pg = page;
            ViewBag.pgList = new List<SelectListItem> {};
            

            TabViewModel msc = new TabViewModel();
            return View(msc);
        }
        
        [HttpPost]
        
        public ActionResult LoadMusicPaper(TabViewModel msc, string page)
        {
            page = Request.Form["PageId"];
            int Colon = page.IndexOf(':') + 1;
            string id = page.Substring(0, page.IndexOf(':'));
            string pgNum = page.Substring(Colon , ((page.Length - 1) - page.IndexOf(':')));
            return Redirect("/Compositions/LoadMusicPaper?id=" + id + "&page=" + pgNum);
        }
    }
}