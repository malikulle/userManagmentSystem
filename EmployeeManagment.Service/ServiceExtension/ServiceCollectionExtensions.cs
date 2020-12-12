using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Data.Concrete;
using EmployeeManagment.Core.Service.Abstract;
using EmployeeManagment.Data.UnitOfWork;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;
using EmployeeManagment.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagment.Service.ServiceExtension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadEntityServices(this IServiceCollection services)
        {
           

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IRepository<UserLeaveType>, Repository<UserLeaveType>>();
            services.AddScoped<IUserLeaveTypeService, UserLeaveTypeManager>();

            services.AddScoped<IRepository<UserLeaveRequest>, Repository<UserLeaveRequest>>();
            services.AddScoped<IUserLeaveRequestService, UserLeaveRequestManager>();

            services.AddScoped<IRepository<UserLeaveAllocation>, Repository<UserLeaveAllocation>>();
            services.AddScoped<IUserLeaveAllocationService, UserLeaveAllocationManager>();

            services.AddScoped<IRepository<WorkOrder>, Repository<WorkOrder>>();
            services.AddScoped<IWorkOrderService, WorkOrderManager>();
            return services;
        }

    }
}
