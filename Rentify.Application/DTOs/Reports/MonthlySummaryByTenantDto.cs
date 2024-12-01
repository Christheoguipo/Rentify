using Rentify.Application.DTOs.Tenant;
using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs.Reports
{
    public record MonthlySummaryByTenantDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public int Month { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal OutstandingBalance { get; set; }

        public required TenantDto Tenant { get; set; }

    }
}
