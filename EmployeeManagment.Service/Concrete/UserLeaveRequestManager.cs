using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Service.Concrete;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;

namespace EmployeeManagment.Service.Concrete
{
    public class UserLeaveRequestManager : Service<UserLeaveRequest> ,IUserLeaveRequestService
    {
        public UserLeaveRequestManager(IRepository<UserLeaveRequest> repository) : base(repository)
        {
        }
    }
}
