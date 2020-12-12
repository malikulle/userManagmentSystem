using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.WebUI.AutoMapper.Profiles
{
    public class UserLeaveTypesProfile : Profile
    {
        public UserLeaveTypesProfile()
        {
            CreateMap<UserLeaveType, UserLeaveTypeDto>();
            CreateMap<UserLeaveTypeDto, UserLeaveType>();

            CreateMap<UserLeaveType, UserLeaveTypeAddDto>();
            CreateMap<UserLeaveTypeAddDto, UserLeaveType>();

            CreateMap<UserLeaveType, UserLeaveTypeEditDto>();
            CreateMap<UserLeaveTypeEditDto, UserLeaveType>();
        }
    }
}
