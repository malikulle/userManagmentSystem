using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveTypeAddDto
    {
        [Required(ErrorMessage = "Ad Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gün Giriniz")]
        public int DefaultDays { get; set; }
    }
}
