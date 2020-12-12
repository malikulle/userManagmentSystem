using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagment.Data.Mappings;
using EmployeeManagment.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Data.Context
{
    public class EmployeeManagmentContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public EmployeeManagmentContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
        }

        #region Tables
        public virtual DbSet<UserLeaveAllocation> UserLeaveAllocations { get; set; }
        public virtual DbSet<UserLeaveType> UserLeaveTypes { get; set; }
        public virtual DbSet<UserLeaveRequest> UserLeaveRequests { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        #endregion
    }
}
