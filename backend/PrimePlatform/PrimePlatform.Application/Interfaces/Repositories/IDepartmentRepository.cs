using PrimePlatform.Domain.Entities;

namespace PrimePlatform.Application.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(Guid id);
        Task<Department> CreateAsync(Department department);
        Task<Department?> UpdateAsync(Department department);
        Task<bool> DeleteAsync(Guid id);
    }
}
