using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.WebUI.AutoMapper.Profiles
{
    public class WorkOrderProfile : Profile
    {
        public WorkOrderProfile()
        {
            CreateMap<WorkOrder, WorkOrderDto>();
            CreateMap<WorkOrderDto, WorkOrder>();

            CreateMap<WorkOrderAddDto, WorkOrder>();
            CreateMap<WorkOrder, WorkOrderAddDto>();

            CreateMap<WorkOrder, WorkOrderEditDto>();
            CreateMap<WorkOrderEditDto, WorkOrder>();
        }
    }
}
