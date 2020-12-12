using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveTypeDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
