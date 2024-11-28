using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs
{
    public record MonthlySummaryByTenantDto
    {
        public int Month { get; set; }
        public required Tenant Tenant { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal OutstandingBalance { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
