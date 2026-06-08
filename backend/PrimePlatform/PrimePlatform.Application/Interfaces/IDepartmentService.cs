using PrimePlatform.Application.DTOs;
using PrimePlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePlatform.Application.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto?> GetByIdAsync(Guid id);
        Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto);
        Task<DepartmentDto?> UpdateAsync(Guid id, UpdateDepartmentDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
