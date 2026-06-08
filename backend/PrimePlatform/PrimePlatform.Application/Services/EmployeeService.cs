using Mapster;
using PrimePlatform.Application.DTOs;
using PrimePlatform.Application.Interfaces;
using PrimePlatform.Application.Interfaces.Repositories;
using PrimePlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePlatform.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDto>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();

            return employees.Adapt<List<EmployeeDto>>();
        }

        public async Task<EmployeeDto?> GetByIdAsync(Guid id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);

            return employee?.Adapt<EmployeeDto>();
        }

        public async Task<EmployeeDto> CreateAsync(CreateEmployeeDto dto)
        {
            var employee = dto.Adapt<Employee>();

            var createdEmployee = await _employeeRepository.CreateAsync(employee);

            return createdEmployee.Adapt<EmployeeDto>();
        }

        public async Task<EmployeeDto?> UpdateAsync(Guid id, UpdateEmployeeDto dto)
        {
            var employee = dto.Adapt<Employee>();

            employee.Id = id;

            var updatedEmployee = await _employeeRepository.UpdateAsync(employee);

            return updatedEmployee?.Adapt<EmployeeDto>();

        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _employeeRepository.DeleteAsync(id);
        }

        
    }
}

