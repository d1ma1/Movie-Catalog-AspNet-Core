using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieCatalogAspNetCore.Data.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string ShortBiography { get; set; }

        public string ActorPhotoUrl { get; set; }

        public ICollection<DirectorMovie> DirectorsMovies { get; set; } = new List<DirectorMovie>();
    }
}
