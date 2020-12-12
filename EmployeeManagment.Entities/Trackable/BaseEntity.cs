using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagment.Entities.Trackable
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; 
        public DateTime? ModifiedDate { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}
