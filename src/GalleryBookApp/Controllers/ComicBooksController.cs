using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GalleryBookApp.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            /* if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
             {
                 return Redirect("/");
             }
             return Content("this is response from the detail action method!"); */
            return View();
        }
            
    }
}