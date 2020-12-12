using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserLeaveRequestEditDto
    {
        public int Id { get; set; }
        public int RequestUserId { get; set; }
        [Required(ErrorMessage = "Lütfen İzin Tipi Seçiniz")]
        public int? UserLeaveTypeId { get; set; }
        [Required(ErrorMessage = "Lütfen Başlangıç Tarihi Belirtiniz")]
        public DateTime? StartDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Lütfen Bitiş Tarihi Belirtiniz")]
        public DateTime? EndDate { get; set; } = DateTime.Now;
        public DateTime RequestDate { get; set; }
        public string Note { get; set; }
    }
}
