using Microsoft.EntityFrameworkCore;
using PrimePlatform.Application.Interfaces.Repositories;
using PrimePlatform.Domain.Entities;
using PrimePlatform.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePlatform.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DBContext _context;

        public DepartmentRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _context.Departments
                .Include(d => d.Employees)
                .ToListAsync();
        }

        public async Task<Department?> GetByIdAsync(Guid id)
        {
            return await _context.Departments
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Department> CreateAsync(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return department;
        }

        public async Task<Department?> UpdateAsync(Department department)
        {
            var existingDepartment = await _context.Departments.FindAsync(department.Id);

            if (existingDepartment == null)
                return null;

            existingDepartment.Name = department.Name;
            existingDepartment.UpdatedOn = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return existingDepartment;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
                return false;

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
