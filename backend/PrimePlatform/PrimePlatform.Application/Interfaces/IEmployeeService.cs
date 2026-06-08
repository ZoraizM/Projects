using PrimePlatform.Application.DTOs;
using PrimePlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePlatform.Application.Interfaces
{
    public interface IEmployeeService
    {

        Task<List<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto?> GetByIdAsync(Guid id);
        Task<EmployeeDto> CreateAsync(CreateEmployeeDto dto);
        Task<EmployeeDto?> UpdateAsync(Guid id, UpdateEmployeeDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
