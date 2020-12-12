using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveAllocationDto
    {
        public int Id { get; set; }

        public int NumberOfDays { get; set; }
        public int Period { get; set; }

        public int UserId { get; set; }
        public virtual UserDto User { get; set; }

        public int UserLeaveTypeId { get; set; }
        public virtual UserLeaveTypeDto UserLeaveType { get; set; }
    }
}
