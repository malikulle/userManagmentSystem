using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagment.WebUI.Controllers
{
    [Authorize]
    public class UserLeaveAllocationController : Controller
    {
        private readonly IUserLeaveAllocationService _myService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserLeaveAllocationController(IUserLeaveAllocationService myService, IMapper mapper, UserManager<User> userManager)
        {
            _myService = myService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;


            var entities = _myService.GetAllAsync(x => x.UserId == user.Id, x => x.UserLeaveType, x => x.User).Result;

            var map = _mapper.Map<List<UserLeaveAllocationDto>>(entities);

            return View(map);
        }
    }
}
