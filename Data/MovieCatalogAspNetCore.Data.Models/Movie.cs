using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using MovieCatalogAspNetCore.Data.Models.Enums;

namespace MovieCatalogAspNetCore.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string MovieImageUrl { get; set; }

        public string MovieTrailerUrl { get; set; }

        [Range(1, 10)]
        public int? Stars { get; set; }

        [Range(1900, 2020)]
        public int Year { get; set; }

        public Genre Genre { get; set; }

        public Country Country { get; set; }

        public string Description { get; set; }

        public ICollection<ActorMovie> ActorsMovies { get; set; } = new List<ActorMovie>();

        public ICollection<DirectorMovie> DirectorsMovies { get; set; } = new List<DirectorMovie>();

    }
}
