namespace MovieCatalogAspNetCore.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using MovieCatalogAspNetCore.Web.ViewModels.InputModels;

    public interface IMoviesService
    {
        Task CreateMovieAsync(MovieInputModel inputModel);
    }
}
