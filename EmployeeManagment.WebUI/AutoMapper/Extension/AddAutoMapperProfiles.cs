using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagment.WebUI.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagment.WebUI.AutoMapper.Extension
{
    public static class AddAutoMapperProfiles
    {
        public static IServiceCollection LoadAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserLeaveTypesProfile)
                , typeof(UserProfile)
                , typeof(UserLeaveRequestProfile)
                , typeof(UserLeaveAllocationProfile)
                , typeof(WorkOrderProfile));

            return services;
        }
    }
}
