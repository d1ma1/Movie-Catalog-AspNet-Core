namespace MovieCatalogAspNetCore.Web.Areas.Administration.Controllers
{
    using MovieCatalogAspNetCore.Common;
    using MovieCatalogAspNetCore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
