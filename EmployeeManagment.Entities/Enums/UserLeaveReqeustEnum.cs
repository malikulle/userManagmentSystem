using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Enums
{
    public enum UserLeaveReqeustEnum
    {
        [Display(Name = "Bekliyor")]
        Waiting = 1,
        [Display(Name = "Onaylandı")]
        Approved = 2,
        [Display(Name = "Reddedildi")]
        Rejected = 3
    }
}
