using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EmployeeManagment.Entities.Enums;

namespace EmployeeManagment.Entities.Dtos
{
    public class WorkOrderEditDto
    {
        public int Id { get; set; }

        public int CreatedUserId { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Kullanıcı Seçiniz")]
        public int? AssignUserId { get; set; }

        public int? ComplatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama Giriniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bir Durum Seçiniz")]
        public WorkOrderStatusEnum WorkOrderStatus { get; set; }
        public string StatusText { get; set; }
        [Required(ErrorMessage = "Lütfen Puan Veriniz")]
        public double? Point { get; set; }
        public string WorkOrderNumber { get; set; }
        public string ImageUrl { get; set; }

    }
}
