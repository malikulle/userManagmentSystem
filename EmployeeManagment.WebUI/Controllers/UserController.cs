using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Models;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagment.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();

            var map = _mapper.Map<List<UserDto>>(users);

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> SetActive(int id , bool value)
        {
            var user =  await _userManager.FindByIdAsync(id.ToString());

            user.IsActive = value;

            await _userManager.UpdateAsync(user);

            return Json(new { Success = true });
        }
    }
}
