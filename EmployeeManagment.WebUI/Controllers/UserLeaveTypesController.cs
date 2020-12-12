using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Data.UnitOfWork;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagment.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserLeaveTypesController : Controller
    {
        private readonly IUserLeaveTypeService _myService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserLeaveTypesController(IUserLeaveTypeService myService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _myService = myService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entities = await _myService.GetAllAsync();

            var map = _mapper.Map<List<UserLeaveTypeDto>>(entities);

            return View(map);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserLeaveTypeAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserLeaveTypeAddDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _mapper.Map<UserLeaveType>(model);

            await _myService.InsertAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            TempData["Success"] = "Başarılı Bir Şekilde Eklendi";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entity = _myService.GetById(id);

            var map = _mapper.Map<UserLeaveTypeEditDto>(entity);

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserLeaveTypeEditDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _mapper.Map<UserLeaveType>(model);

            await _myService.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            TempData["Success"] = "Başarılı Bir Şekilde Güncellendi";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            var entity = _myService.GetById(id);

            try
            {

                await _myService.DeleteAsync(entity);
                await _unitOfWork.SaveChangesAsync();

                return Json(new { success = true });
            }
            catch (Exception e)
            {
                return Json(new { success = false });
            }

        }
    }
}
