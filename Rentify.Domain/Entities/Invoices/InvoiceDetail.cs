using Rentify.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities.Invoices
{
    public class InvoiceDetail
    {
        [Required]
        public required ChargeType ChargeType { get; set; }

        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string? Description { get; set; }

        public decimal Amount { get; set; }
    }
}