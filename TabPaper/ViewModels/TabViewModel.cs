using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TabPaper.ViewModels

{
    
    public class TabViewModel
    {

        [Display(Name = "PageId")]
        public string PageId { get; set; }
        
        public List<SelectListItem> pgList { get; set; } = new List<SelectListItem>();
        public TabViewModel()
        {
            
                for (int pg = 0; pg > 8; pg++)
                {
                    pgList.Add(new SelectListItem
                    {
                        Value = pg.ToString(),
                        Text = pg.ToString()
                    });
                }
            
            
            
           
        }
       

    }
}
