using Microsoft.EntityFrameworkCore;
using PrimePlatform.Domain.Entities;

namespace PrimePlatform.Infrastructure.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) {}

        public DbSet<Employee> Employees { get; set; } = null!;

        public DbSet<Department> Departments { get; set; } = null!;

        public DbSet<EmployeeTimeLog> EmployeeTimeLogs { get; set; } = null!;

        public DbSet<LeaveRequest> LeaveRequests { get; set; } = null!;
    }
}
