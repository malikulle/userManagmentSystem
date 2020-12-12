using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Entities.Models;

namespace EmployeeManagment.Entities.Dtos
{
    public class LoggedInUserDto
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
