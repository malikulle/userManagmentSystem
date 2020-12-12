using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Enums;

namespace EmployeeManagment.Entities.Dtos
{
    public class WorkOrderDto
    {
        public int Id { get; set; }

        public int CreatedUserId { get; set; }
        public virtual UserDto CreatedUser { get; set; }

        public int? AssignUserId { get; set; }
        public virtual UserDto AssignUser { get; set; }

        public int? ComplatedUserId { get; set; }
        public virtual UserDto ComplatedUser { get; set; }

        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public WorkOrderStatusEnum WorkOrderStatus { get; set; }
        public string StatusText { get; set; }
        public double? Point { get; set; }
        public string WorkOrderNumber { get; set; }
        public string ImageUrl { get; set; }
    }
}
