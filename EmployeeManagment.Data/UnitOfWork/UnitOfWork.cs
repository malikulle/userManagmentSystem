using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Data.Context;

namespace EmployeeManagment.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagmentContext _context;

        public UnitOfWork(EmployeeManagmentContext context)
        {
            _context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
          return  await _context.SaveChangesAsync();
        }

        public int SaveChange()
        {
            return _context.SaveChanges();
        }
    }
}
