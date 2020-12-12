using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Service.Concrete;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Service.Concrete
{
    public class UserLeaveTypeManager :Service<UserLeaveType> ,IUserLeaveTypeService
    {
        public UserLeaveTypeManager(IRepository<UserLeaveType> repository) : base(repository)
        {
        }
    }
}
