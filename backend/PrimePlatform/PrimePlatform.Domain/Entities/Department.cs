using PrimePlatform.Domain.Common;


namespace PrimePlatform.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();
    }
}
