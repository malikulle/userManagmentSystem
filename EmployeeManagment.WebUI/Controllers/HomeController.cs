using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Localization;

namespace EmployeeManagment.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> _localizer;

        public HomeController(IHtmlLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var test = _localizer["hello.world"];
            ViewData["hello.world"] = test;

            return View();
        }

        [HttpPost]
        public IActionResult CultureManagment(string culture,string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),new CookieOptions(){Expires = DateTimeOffset.Now.AddDays(30)});

            return LocalRedirect(returnUrl);
        }
    }
}
