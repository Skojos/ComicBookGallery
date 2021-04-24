using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Detail()
        {

            var seriesTitle = "The Amazing Spider-Man";
            var issueNumber = 700;
            var description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            var artists = new string[]
            {
        "Script: Dan Slott",
        "Pencils: Humberto Ramos",
        "Inks: Victor Olazaba",
        "Colors: Edgar Delgado",
        "Letters: Chris Eliopoulos"
            };
        
            return View();
        }

    }
}
