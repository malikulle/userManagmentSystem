using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Enums;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveRequestDto
    {
        public int Id { get; set; }
        public int RequestUserId { get; set; }
        public virtual UserDto RequestUser { get; set; }

        public int? ApprovedUserId { get; set; }
        public virtual UserDto User { get; set; }

        public int UserLeaveTypeId { get; set; }
        public UserLeaveTypeDto UserLeaveType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RequestDate { get; set; }
        public string Note { get; set; }
        public UserLeaveReqeustEnum Status { get; set; }

        public string StatusText { get; set; }

    }
}
