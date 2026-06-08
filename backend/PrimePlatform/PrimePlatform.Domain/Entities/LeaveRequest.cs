using PrimePlatform.Domain.Common;
using PrimePlatform.Domain.Enums;


namespace PrimePlatform.Domain.Entities
{
    public class LeaveRequest : BaseEntity
    {
        public Guid EmployeeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Reason { get; set; } = string.Empty;

        public LeaveStatus Status { get; set; } = LeaveStatus.Pending;

        public Employee Employee { get; set; } = null!;
    }
}
