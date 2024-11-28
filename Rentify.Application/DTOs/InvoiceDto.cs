using Rentify.Domain.Entities.Invoices;
using Rentify.Domain.Entities.Payments;
using Rentify.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Application.DTOs
{
    public record InvoiceDto
    {
        public int InvoiceNumber { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public DateOnly DueDate { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal OutstandingBalance => TotalAmount - PaidAmount;
        public ConsolidationPeriod? ConsolidationPeriod { get; set; }

        public required ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public ICollection<Payment>? Payments { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
