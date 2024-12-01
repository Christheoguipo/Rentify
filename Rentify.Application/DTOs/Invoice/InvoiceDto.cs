using Rentify.Application.DTOs.InvoiceDetail;
using Rentify.Application.DTOs.Payment;
using Rentify.Application.DTOs.Tenant;
using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs.Invoice
{
    public record InvoiceDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public User? ModifiedBy { get; set; }
        public int InvoiceNumber { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public DateOnly DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal OutstandingBalance => TotalAmount - PaidAmount;


        public required TenantDto Tenant { get; set; }
        public required ICollection<InvoiceDetailDto> InvoiceDetails { get; set; }
        public ICollection<PaymentDto>? Payments { get; set; }
        public ConsolidationPeriodDto? ConsolidationPeriod { get; set; }
    }
}
