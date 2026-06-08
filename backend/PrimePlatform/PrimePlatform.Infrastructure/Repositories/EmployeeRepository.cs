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
        public class EmployeeRepository : IEmployeeRepository
        {
            private readonly DBContext _context;

            public EmployeeRepository(DBContext context)
            {
                _context = context;
            }

            public async Task<List<Employee>> GetAllAsync()
            {
                return await _context.Employees
                    .Include(e => e.Department)
                    .ToListAsync();
            }

            public async Task<Employee?> GetByIdAsync(Guid id)
            {
                return await _context.Employees
                    .Include(e => e.Department)
                    .FirstOrDefaultAsync(e => e.Id == id);
            }

            public async Task<Employee> CreateAsync(Employee employee)
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return employee;
            }

            public async Task<Employee?> UpdateAsync(Employee employee)
            {
                var existingEmployee = await _context.Employees.FindAsync(employee.Id);

                if (existingEmployee == null)
                    return null;

                existingEmployee.EmployeeCode = employee.EmployeeCode;
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Email = employee.Email;
                existingEmployee.MonthlySalary = employee.MonthlySalary;
                existingEmployee.DepartmentId = employee.DepartmentId;
                existingEmployee.UpdatedOn = DateTime.UtcNow;

                await _context.SaveChangesAsync();

                return existingEmployee;
            }

            public async Task<bool> DeleteAsync(Guid id)
            {
                var employee = await _context.Employees.FindAsync(id);

                if (employee == null)
                    return false;

                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();

                return true;
            }
        }

    }

