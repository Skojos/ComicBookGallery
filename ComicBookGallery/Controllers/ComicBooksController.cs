﻿using System;
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

            return View();
        }

    }
}