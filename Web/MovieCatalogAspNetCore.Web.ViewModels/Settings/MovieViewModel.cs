using MovieCatalogAspNetCore.Data.Models;
using MovieCatalogAspNetCore.Data.Models.Enums;
using MovieCatalogAspNetCore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCatalogAspNetCore.Web.ViewModels.Settings
{
    public class MovieViewModel : IMapFrom<Movie>
    {
        // public int Id { get; set; }
        public string Title { get; set; }

        // public string MovieImageUrl { get; set; }

        // public string MovieTrailerUrl { get; set; }
        public int Stars { get; set; }

        public int Year { get; set; }

        public Genre Genre { get; set; }

        public Country Country { get; set; }

        public string Description { get; set; }

        public ICollection<ActorMovie> ActorsMovies { get; set; }

        public List<DirectorMovie> Directors { get; set; }
    }
}
