namespace MovieCatalogAspNetCore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using MovieCatalogAspNetCore.Data.Common.Models;

    public class Actor : BaseDeletableModel<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string StageName { get; set; }

        public string ShortBiography { get; set; }

        public string ActorPhotoUrl { get; set; }

        public ICollection<ActorMovie> ActorsMovies { get; set; } = new List<ActorMovie>();
    }
}
