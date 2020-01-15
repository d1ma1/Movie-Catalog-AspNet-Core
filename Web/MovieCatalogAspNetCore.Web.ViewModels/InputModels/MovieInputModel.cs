namespace MovieCatalogAspNetCore.Web.ViewModels.InputModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;
    using MovieCatalogAspNetCore.Data.Models;
    using MovieCatalogAspNetCore.Data.Models.Enums;
    using MovieCatalogAspNetCore.Services.Mapping;

    public class MovieInputModel : IMapFrom<Movie>
    {
        private const int TitleMinLength = 5;
        private const int TitleMaxLength = 120;
        private const string TitleLengthErrorMessage = "{0} should be between {2} and {1} characters length!";
        private const int DescriptionMinLength = 20;

        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = TitleLengthErrorMessage)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Stars { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public Country Country { get; set; }

        [MinLength(DescriptionMinLength)]
        [Required]
        public string Description { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        [DataType(DataType.Upload)]
        [Required]
        public ICollection<IFormFile> MovieImageUrl { get; set; }

        [DataType(DataType.Upload)]
        [Required]
        public ICollection<IFormFile> MovieTrailerUrl { get; set; }
    }
}
