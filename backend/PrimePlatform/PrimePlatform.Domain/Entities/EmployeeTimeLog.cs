using PrimePlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePlatform.Domain.Entities
{
    public class EmployeeTimeLog : BaseEntity
    {
        public Guid EmployeeId { get; set; }

        public DateTime WorkedDate { get; set; }

        public decimal WorkedHours { get; set; }

        public string WorkedDescription { get; set; } = string.Empty;

        public Employee Employee { get; set; } = null!;
    }
}
