using PrimePlatform.Domain.Common;


namespace PrimePlatform.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string EmployeeCode { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime JoiningDate { get; set; }

        public decimal MonthlySalary { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; } = null!;
    }
}
