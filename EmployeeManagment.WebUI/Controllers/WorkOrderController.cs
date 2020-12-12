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
using EmployeeManagment.WebUI.Helpers.Abstarct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.WebUI.Controllers
{
    public class WorkOrderController : Controller
    {
        private readonly IWorkOrderService _myService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly IImageHelper _imageHelper;
        private readonly IMapper _mapper;
        public WorkOrderController(IWorkOrderService myService, IMapper mapper, UserManager<User> userManager, IUnitOfWork unitOfWork, IImageHelper imageHelper)
        {
            _myService = myService;
            _mapper = mapper;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _imageHelper = imageHelper;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var roles = _userManager.GetRolesAsync(user).Result;

            List<WorkOrder> entities = new List<WorkOrder>();

            if (roles.Any(x => x.Equals("Admin")))
            {
                entities =
                    _myService.GetAllAsync(null, x => x.AssignUser, x => x.CreatedUser, x => x.ComplatedUser).Result;
            }
            else
            {
                entities =
                    _myService.GetAllAsync(x => x.AssignUserId == user.Id, x => x.AssignUser, x => x.CreatedUser, x => x.ComplatedUser).Result;
            }

            var map = _mapper.Map<List<WorkOrderDto>>(entities);

            map.ForEach(item =>
            {
                item.StatusText = EnumExtension<WorkOrderStatusEnum>.GetDisplayValue(item.WorkOrderStatus);
            });

            ViewBag.AllowCreate = roles.Any(x => x.Equals("Admin"));
            return View(map);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View(new WorkOrderAddDto());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(WorkOrderAddDto model, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            var user = await _userManager.GetUserAsync(HttpContext.User);

            var entity = _mapper.Map<WorkOrder>(model);
            entity.CreatedUserId = user.Id;
            entity.WorkOrderStatus = WorkOrderStatusEnum.Created;
            entity.WorkOrderNumber = new Random().Next(111111, 999999).ToString();

            if (file != null)
            {
                var result = await _imageHelper.UploadPicture(file);
                entity.ImageUrl = result.FullName;
            }


            await _myService.InsertAsync(entity);

            await _unitOfWork.SaveChangesAsync();

            TempData["Success"] = "Başarılı Bir Şekilde Eklendi";

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = _myService.GetById(id);

            var model = _mapper.Map<WorkOrderEditDto>(entity);

            var users = await _userManager.Users.ToListAsync();

            ViewBag.Users = users.Select(x => new SelectListItem()
            {
                Text = x.FirstName + " " + x.LastName,
                Value = x.Id.ToString()
            }).ToList();

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Edit(WorkOrderEditDto model, IFormFile file)
        {
            if (!ModelState.IsValid)
            {

                var users = await _userManager.Users.ToListAsync();

                ViewBag.Users = users.Select(x => new SelectListItem()
                {
                    Text = x.FirstName + " " + x.LastName,
                    Value = x.Id.ToString()
                }).ToList();
                return View(model);
            }

            var entity = _mapper.Map<WorkOrder>(model);
            if (file != null)
            {
                string oldImagePath = entity.ImageUrl;
                var result = await _imageHelper.UploadPicture(file);
                entity.ImageUrl = result.FullName;
                _imageHelper.Delete(oldImagePath);
            }
            await _myService.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            TempData["Success"] = "Başarılı Bir Şekilde Güncellendi";


            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            var entity = _myService.GetById(id);

            if (entity.ImageUrl != null)
            {
                _imageHelper.Delete(entity.ImageUrl);
            }

            await _myService.DeleteAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            return Json(new { Success = true });
        }
    }
}
