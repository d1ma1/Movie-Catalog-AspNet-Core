namespace MovieCatalogAspNetCore.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using AutoMapper;
    using MovieCatalogAspNetCore.Data;
    using MovieCatalogAspNetCore.Data.Models;
    using MovieCatalogAspNetCore.Services.Data.Contracts;
    using MovieCatalogAspNetCore.Web.ViewModels.InputModels;

    public class MoviesService : IMoviesService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MoviesService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task CreateMovieAsync(MovieInputModel inputModel)
        {
            var movie = this.mapper.Map<Movie>(inputModel);

            // movie.ActorsMovies = Actors
            //    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();
            // movie.DirectorsMovies = Directors
            //    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Movie> entityEntry = await this.context.Movies.AddAsync(movie);
            await this.context.SaveChangesAsync();
        }
    }
}
