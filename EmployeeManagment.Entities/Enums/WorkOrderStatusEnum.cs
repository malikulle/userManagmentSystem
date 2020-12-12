using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Enums
{
    public enum WorkOrderStatusEnum
    {
        [Display(Name = "İş Emri Oluşturuldu")]
        Created = 1,
        [Display(Name = "Atandı")]
        Assign = 2,
        [Display(Name = "Üstlenildi")]
        UnderTake = 3,
        [Display(Name = "Kapatıldı")]
        Closed = 4

    }
}
