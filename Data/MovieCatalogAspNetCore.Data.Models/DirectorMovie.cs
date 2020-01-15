namespace MovieCatalogAspNetCore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MovieCatalogAspNetCore.Data.Common.Models;

    public class DirectorMovie : BaseDeletableModel<int>
    {
        public int DirectorId { get; set; }

        public Director Director { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
