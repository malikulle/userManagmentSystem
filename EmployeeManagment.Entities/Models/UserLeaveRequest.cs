using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Enums;
using EmployeeManagment.Entities.Trackable;

namespace EmployeeManagment.Entities.Models
{
    public class UserLeaveRequest : BaseEntity,IEntity
    {
        public int RequestUserId { get; set; }
        public virtual User RequestUser { get; set; }

        public int? ApprovedUserId { get; set; }
        public virtual User ApprovedUser { get; set; }

        public int UserLeaveTypeId { get; set; }
        public UserLeaveType UserLeaveType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RequestDate { get; set; }
        public string Note { get; set; }
        public UserLeaveReqeustEnum Status { get; set; }
    }
}
