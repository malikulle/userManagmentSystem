using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Core.Extensions;
using EmployeeManagment.Data.UnitOfWork;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Enums;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagment.WebUI.Controllers
{
    [Authorize]
    public class UserLeaveRequestController : Controller
    {
        private readonly IUserLeaveRequestService _myService;
        private readonly IUserLeaveTypeService _userLeaveTypeService;
        private readonly IUserLeaveAllocationService _userLeaveAllocationService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public UserLeaveRequestController(IUserLeaveRequestService myService, UserManager<User> userManager, IMapper mapper, IUserLeaveTypeService userLeaveTypeService, IUnitOfWork unitOfWork, IUserLeaveAllocationService userLeaveAllocationService)
        {
            _myService = myService;
            _userManager = userManager;
            _mapper = mapper;
            _userLeaveTypeService = userLeaveTypeService;
            _unitOfWork = unitOfWork;
            _userLeaveAllocationService = userLeaveAllocationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var roles = _userManager.GetRolesAsync(user).Result;

            List<UserLeaveRequest> entities = new List<UserLeaveRequest>();

            if (roles.Any(x=> x.Equals("Admin")))
            {
                entities = await _myService.GetAllAsync(null, x => x.RequestUser,
                    x => x.UserLeaveType, x => x.ApprovedUser);
            }
            else
            {
                entities = await _myService.GetAllAsync(x => x.RequestUserId == user.Id, x => x.RequestUser,
                    x => x.UserLeaveType, x => x.ApprovedUser);
            }
            

            entities = entities.OrderByDescending(x => x.RequestDate).ToList();

            var map = _mapper.Map<List<UserLeaveRequestDto>>(entities);

            map.ForEach(item =>
            {
                item.StatusText = EnumExtension<UserLeaveReqeustEnum>.GetDisplayValue(item.Status);
            });

            ViewBag.ShowEdit = roles.Any(x => x.Equals("Admin"));


            return View(map);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var entities = _userLeaveTypeService.GetAllAsync().Result;
            var user = _userManager.GetUserAsync(HttpContext.User).Result;

            var map = _mapper.Map<List<UserLeaveTypeDto>>(entities);
            
            ViewBag.LeaveTypes = map.Select(x=> new SelectListItem(){Text = x.Name ,Value = x.Id.ToString()}).ToList();

            var model = new UserLeaveRequestAddDto {RequestUserId = user.Id};

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserLeaveRequestAddDto model)
        {
            if (!ModelState.IsValid)
            { 
                var entities = _userLeaveTypeService.GetAllAsync().Result;
                var user = _userManager.GetUserAsync(HttpContext.User).Result;

                var map = _mapper.Map<List<UserLeaveTypeDto>>(entities);
                ViewBag.LeaveTypes = map.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();

                model.RequestUserId = user.Id;
                return View(model);
            }

            var entity = _mapper.Map<UserLeaveRequest>(model);
            entity.RequestDate = DateTime.Now;;
            var type =  _userLeaveTypeService.GetById(entity.UserLeaveTypeId);
            entity.EndDate = entity.StartDate.AddDays(type.DefaultDays);
            entity.Status = UserLeaveReqeustEnum.Waiting;
            await _myService.InsertAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            TempData["Success"] = "Başarılı Bir Şekilde Eklendi";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entity = _myService.GetById(id);

            var model = _mapper.Map<UserLeaveRequestEditDto>(entity);
            var entities = _userLeaveTypeService.GetAllAsync().Result;
            var map = _mapper.Map<List<UserLeaveTypeDto>>(entities);

            ViewBag.LeaveTypes = map.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult>  Edit(UserLeaveRequestEditDto model)
        {
            if (!ModelState.IsValid)
            {
                var entities = _userLeaveTypeService.GetAllAsync().Result;
                var map = _mapper.Map<List<UserLeaveTypeDto>>(entities);
                
                ViewBag.LeaveTypes = map.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();

                return View(model);
            }

            var entity = _mapper.Map<UserLeaveRequest>(model);
            await _myService.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            TempData["Success"] = "Başarılı Bir Şekilde Güncellendi";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {

                var entity = _myService.GetById(id);

                await _myService.DeleteAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                return Json(new {Success = true});
            }
            catch (Exception e)
            {
                return Json(new { Success = false });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                var entity = _myService.GetById(id);
                entity.Status = UserLeaveReqeustEnum.Approved;
                entity.ApprovedUserId = user.Id;

                var allocation = new UserLeaveAllocation()
                {
                    NumberOfDays = ((TimeSpan)(entity.EndDate.Date - entity.StartDate.Date)).Days,
                    Period = 1,
                    UserLeaveTypeId = entity.UserLeaveTypeId,
                    UserId = entity.RequestUserId
                };

                await _userLeaveAllocationService.InsertAsync(allocation);

                await _myService.UpdateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                return Json(new { Success = true });
            }
            catch (Exception e)
            {
                return Json(new { Success = false });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Cancel(int id)
        {
            try
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                var entity = _myService.GetById(id);
                entity.Status = UserLeaveReqeustEnum.Rejected;
                entity.ApprovedUserId = user.Id;

                await _myService.UpdateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                return Json(new { Success = true });
            }
            catch (Exception e)
            {
                return Json(new { Success = false });
            }
        }
    }
}
