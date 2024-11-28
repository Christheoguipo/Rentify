using Rentify.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Application.DTOs
{
    public record InvoiceDetailDto
    {
        public required ChargeType ChargeType { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
    }
}
