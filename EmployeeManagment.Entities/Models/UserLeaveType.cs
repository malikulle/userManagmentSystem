using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Trackable;

namespace EmployeeManagment.Entities.Models
{
    public class UserLeaveType : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
