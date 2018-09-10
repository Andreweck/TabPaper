using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TabPaper.ViewModels

{
    public class TabViewModel
    {

        public List<string> indvdlStrng { get; set; } = new List<string> { };

        public List<List<string>> indvdlne { get; set; }

        public List<List<List<string>>> WholeProject { get; set; }

        public List<Dictionary<int, List<List<List<string>>>>> projectList { get; set; }

        public List<string> Jobs { get; set; } = new List<string>();

        public Dictionary<int, List<List<List<String>>>> AddThis { get; set; }
        public int position = 0;

        public TabViewModel()
        {
            
            
            indvdlne = new List<List<string>> { };
            WholeProject = new List<List<List<string>>> { };
            projectList = new List<Dictionary<int, List<List<List<string>>>>>{ };
            int position = new int {};
            AddThis = new Dictionary<int, List<List<List<string>>>> { };
            
           
        }
        public TabViewModel(TabViewModel vwmdl) : this()
        {
            /*ofcourseIneedthis = new Dictionary<string, TabViewModel>{};
            ofcourseIneedthis.Add(position, vwmdl);
            dtabs.Add(ofcourseIneedthis);
            position += 1;*/
        }

    }
}
