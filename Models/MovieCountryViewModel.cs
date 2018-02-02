using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieCountryViewModel
    {
        public List<Movie> movies;
        public SelectList countries;
        public string movieCountry { get; set; }
    }
}
