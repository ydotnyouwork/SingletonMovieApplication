using OnlineWeek4Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineWeek4Day4.Controllers
{
    public class HomeController : Controller
    {
        private Db db = Db.Instance;

        public ActionResult Index()
        {
            return View(db.Movies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddMovie()
        {
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult AddMovie(Movie model)
        {
            model.Id = db.Movies.Select(x => x.Id).LastOrDefault() + 1;
            db.Movies.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMovie(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index");

            if (db.Movies.Any(x => x.Id == id))
            {
                Movie movie = db.Movies.Where(x => x.Id == id).FirstOrDefault();
                db.Movies.Remove(movie);
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditMovie(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index");

            if (db.Movies.Any(x => x.Id == id))
            {
                Movie movie = db.Movies.Where(x => x.Id == id).FirstOrDefault();
                TempData["EditId"] = id;
                return View("AddMovie", movie);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            int id = (int)TempData["EditId"];

            foreach (Movie movie in db.Movies)
            {
                if (movie.Id == id && id == model.Id)
                {
                    movie.Clone(model);
                }
            }
            return RedirectToAction("Index");
        }
    }
}