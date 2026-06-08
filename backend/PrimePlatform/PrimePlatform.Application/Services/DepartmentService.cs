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
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<List<DepartmentDto>> GetAllAsync()
        {
            var departments = await _departmentRepository.GetAllAsync();

            return departments.Adapt<List<DepartmentDto>>();
        }

        public async Task<DepartmentDto?> GetByIdAsync(Guid id)
        {
            var department = await _departmentRepository.GetByIdAsync(id);

            if (department == null)
                return null;

            return department.Adapt<DepartmentDto>();
        }

        public async Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto)
        {
            var department = dto.Adapt<Department>();

            var createdDepartment =
                await _departmentRepository.CreateAsync(department);

            return createdDepartment.Adapt<DepartmentDto>();
        }

        public async Task<DepartmentDto?> UpdateAsync(Guid id, UpdateDepartmentDto dto)
        {
            var department = dto.Adapt<Department>();

            department.Id = id;

            var updatedDepartment =
                await _departmentRepository.UpdateAsync(department);

            return updatedDepartment?.Adapt<DepartmentDto>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _departmentRepository.DeleteAsync(id);
        }
    }
}
