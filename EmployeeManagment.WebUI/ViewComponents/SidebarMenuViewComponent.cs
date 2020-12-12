using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace EmployeeManagment.WebUI.ViewComponents
{
    public class SidebarMenuViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public SidebarMenuViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke()
        {

            var user = _userManager.GetUserAsync(HttpContext.User).Result;

            var roles = _userManager.GetRolesAsync(user).Result;

            var model = new LoggedInUserDto()
            {
                User = user,
                Roles = roles
            };
            return View(model);
        }
    }
}
