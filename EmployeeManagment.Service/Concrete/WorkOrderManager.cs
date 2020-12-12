using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Core.Service.Concrete;
using EmployeeManagment.Entities.Models;
using EmployeeManagment.Service.Abstract;

namespace EmployeeManagment.Service.Concrete
{
    public class WorkOrderManager : Service<WorkOrder>, IWorkOrderService
    {
        public WorkOrderManager(IRepository<WorkOrder> repository) : base(repository)
        {
        }
    }
}
