using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveTypeEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gün Giriniz")]
        [DisplayName("Default Gün Sayısı")]
        public int DefaultDays { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
