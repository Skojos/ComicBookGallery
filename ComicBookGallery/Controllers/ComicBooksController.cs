using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Models;
using ComicBookGallery.Repository;
using Microsoft.AspNetCore.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }

        
    }
}
