using Rentify.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        [Required]
        public int InvoiceNumber { get; set; }
        [Required]
        public DateOnly InvoiceDate { get; set; }
        [Required]
        public DateOnly DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal OutstandingBalance => TotalAmount - PaidAmount;


        [Required]
        public required Tenant Tenant { get; set; }
        [Required]
        public required ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ConsolidationPeriod? ConsolidationPeriod { get; set; }

    }
}
