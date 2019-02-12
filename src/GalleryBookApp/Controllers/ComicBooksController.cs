using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GalleryBookApp.Controllers    
{
    public class ComicBooksController : Controller
    {
       /* public string SeriesTitle { set; get; }
        public int IssueNumber { set; get; }
        public string Description { set;  get; }
        public string[] Artists { set; get; } */
        public ActionResult Detail()
        {


              ViewBag.SeriesTitle = "The Amazing Spider-Man";
              ViewBag.IssueNumber = 700;
              ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
              ViewBag.Artists = new string[]
              {
              "Script: Dan Slott",
              "Pencils: Humberto Ramos",
              "Inks: Victor Olazaba",
              "Colors: Edgar Delgado",
              "Letters: Chris Eliopoulos"
              };  
           
            /* if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
             {
                 return Redirect("/");
             }
             return Content("this is response from the detail action method!"); */
            return View();
        }
            
    }
}