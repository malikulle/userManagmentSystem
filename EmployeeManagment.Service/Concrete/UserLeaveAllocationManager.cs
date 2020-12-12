using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Service.Concrete;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;

namespace EmployeeManagment.Service.Concrete
{
    public class UserLeaveAllocationManager : Service<UserLeaveAllocation> , IUserLeaveAllocationService
    {
        public UserLeaveAllocationManager(IRepository<UserLeaveAllocation> repository) : base(repository)
        {
        }
    }
}
