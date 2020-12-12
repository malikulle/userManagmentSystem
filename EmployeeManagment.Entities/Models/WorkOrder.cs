using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Enums;
using EmployeeManagment.Entities.Trackable;

namespace EmployeeManagment.Entities.Models
{
    public class WorkOrder : BaseEntity , IEntity
    {
        public int CreatedUserId { get; set; }
        public virtual User CreatedUser { get; set; }

        public int? AssignUserId { get; set; }
        public virtual User AssignUser { get; set; }

        public int? ComplatedUserId { get; set; }
        public virtual User ComplatedUser { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public WorkOrderStatusEnum WorkOrderStatus { get; set; }
        public double? Point { get; set; }
        public string WorkOrderNumber { get; set; }

    }
}
