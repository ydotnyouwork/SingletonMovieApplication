using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineWeek4Day4.Models
{
    public class Db
    {
        // Properites
        public List<Movie> Movies { get; set; }

        public static Db Instance
        {
            get
            {
                return _instance ?? (_instance = CreateDb());
            }
        }
        private static Db _instance;

        private static Db CreateDb()
        {
            return new Db()
            {
                // Seed our properties
                Movies = new List<Movie>()
                {
                    new Movie() { Name = "Lilo And Stitch", Id = 1, Year = 2000, FilmRating = FilmRating.PG, ImageUrl = "http://www.smiley-faces.org/wallpaper/smiley-face-wallpaper-014.jpg" },
                    new Movie() { Name = "Aladdin", Year = 1985, Id = 2, FilmRating = FilmRating.R, ImageUrl = "http://www.smiley-faces.org/wallpaper/smiley-face-wallpaper-014.jpg" },
                    new Movie() { Name = "Dumbo", Year = 1980, Id = 3, FilmRating = FilmRating.G, ImageUrl = "http://www.smiley-faces.org/wallpaper/smiley-face-wallpaper-014.jpg" },
                    new Movie() { Name = "Peter pan", Year = 1987, Id = 4, FilmRating = FilmRating.NC17, ImageUrl = "http://www.smiley-faces.org/wallpaper/smiley-face-wallpaper-014.jpg" },
                }
            };
        }

        private Db()
        {
        }
    }
}