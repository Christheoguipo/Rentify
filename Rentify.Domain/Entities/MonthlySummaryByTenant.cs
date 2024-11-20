using Rentify.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class MonthlySummaryByTenant: BaseEntity
    {
       
        [Range(1,12)]
        public int Month { get; set; }

        public required Tenant Tenant { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal OutstandingBalance { get; set; }
    }
}
