namespace MovieCatalogAspNetCore.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using MovieCatalogAspNetCore.Data;
    using MovieCatalogAspNetCore.Data.Common.Models;
    using MovieCatalogAspNetCore.Data.Models;
    using MovieCatalogAspNetCore.Data.Models.Enums;
    using MovieCatalogAspNetCore.Services.Data.Contracts;
    using MovieCatalogAspNetCore.Web.ViewModels.InputModels;

    public class MovieController : Controller
    {
        // private readonly IMoviesService moviesService;

        // public MovieController(IMoviesService moviesService)
        // {
        //    this.moviesService = moviesService;
        // }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return this.View();
        }

       // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            // await moviesService.CreateMovieAsync(inputModel);

            // TempData["CreatedAd"] = SuccessfullyCreatedAdMessage;

            // return RedirectToAction("WaitingForApproval");
            return this.RedirectToAction("WaitingForApproval");
        }
    }
}
