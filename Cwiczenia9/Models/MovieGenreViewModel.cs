using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Cwiczenia9.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public SelectList Ratings { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public string Rating { get; set; }
    }
}
