using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Trackable;

namespace EmployeeManagment.Entities.Models
{
    public class UserLeaveAllocation : BaseEntity,IEntity
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int UserLeaveTypeId { get; set; }
        public virtual UserLeaveType UserLeaveType { get; set; }
    }
}
