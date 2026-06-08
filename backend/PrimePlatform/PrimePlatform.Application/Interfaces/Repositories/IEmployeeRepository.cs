using PrimePlatform.Domain.Entities;

namespace PrimePlatform.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(Guid id);
        Task<Employee> CreateAsync(Employee employee);
        Task<Employee?> UpdateAsync(Employee employee);
        Task<bool> DeleteAsync(Guid id);
    }
}
