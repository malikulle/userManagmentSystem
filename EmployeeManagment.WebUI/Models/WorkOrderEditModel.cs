using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.Entities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagment.WebUI.Models
{
    public class WorkOrderEditModel
    {
        public WorkOrderEditDto WorkOrder { get; set; }
        public List<SelectListItem> Users { get; set; }
    }
}
