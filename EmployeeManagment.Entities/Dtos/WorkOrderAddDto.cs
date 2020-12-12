using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EmployeeManagment.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagment.Entities.Dtos
{
    public class WorkOrderAddDto
    {
        [Required(ErrorMessage = "Lütfen Puan Tanımlayınız")]
        public double? Point { get; set; }
        [Required(ErrorMessage = "Lütfen İş Emri Açıklaması Giriniz")]
        public string Description { get; set; }
    }
}
