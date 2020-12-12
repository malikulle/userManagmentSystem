using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Core.Data.Abstract;
using EmployeeManagment.Entities.Trackable;

namespace EmployeeManagment.Core.Service.Abstract
{
    public interface IService<T> : IRepository<T>
        where T : BaseEntity, IEntity, new()
    {
    }
}
