using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.WebUI.AutoMapper.Profiles
{
    public class UserLeaveRequestProfile : Profile
    {
        public UserLeaveRequestProfile()
        {
            CreateMap<UserLeaveRequest, UserLeaveRequestDto>();
            CreateMap<UserLeaveRequestDto, UserLeaveRequest>();

            CreateMap<UserLeaveRequestAddDto, UserLeaveRequest>();
            CreateMap<UserLeaveRequest, UserLeaveRequestAddDto>();

            CreateMap<UserLeaveRequestEditDto, UserLeaveRequest>();
            CreateMap<UserLeaveRequest, UserLeaveRequestEditDto>();
        }
    }
}
