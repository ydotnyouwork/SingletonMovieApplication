using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineWeek4Day4.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public FilmRating FilmRating { get; set; }

        [Editable(false)]
        public int Id { get; set; }

        public void Clone(Movie movie, bool copyId = false)
        {
            this.Name = movie.Name;
            this.Year = movie.Year;
            this.ImageUrl = movie.ImageUrl;
            this.FilmRating = movie.FilmRating;

            if (copyId) this.Id = movie.Id;
        }
    }

    public enum FilmRating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }
}