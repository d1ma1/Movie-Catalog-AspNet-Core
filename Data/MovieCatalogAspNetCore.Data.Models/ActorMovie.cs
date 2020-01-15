namespace MovieCatalogAspNetCore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MovieCatalogAspNetCore.Data.Common.Models;

    public class ActorMovie : BaseDeletableModel<int>
    {
        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
