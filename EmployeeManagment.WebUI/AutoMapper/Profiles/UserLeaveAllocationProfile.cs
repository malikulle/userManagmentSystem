using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.WebUI.AutoMapper.Profiles
{
    public class UserLeaveAllocationProfile :Profile
    {
        public UserLeaveAllocationProfile()
        {
            CreateMap<UserLeaveAllocation, UserLeaveAllocationDto>();
            CreateMap<UserLeaveAllocationDto, UserLeaveAllocation>();
        }
    }
}
