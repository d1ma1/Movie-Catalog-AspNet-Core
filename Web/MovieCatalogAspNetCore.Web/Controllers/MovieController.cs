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
using MovieCatalogAspNetCore.Web.ViewModels.Settings;

namespace MovieCatalogAspNetCore.Web.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Create
        public IActionResult Create()
        {
            return this.View();
        }
    }
}
