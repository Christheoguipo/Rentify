using Rentify.Domain.Common.Enums;
using Rentify.Domain.Entities.AdvancePayments;

namespace Rentify.Application.DTOs
{
    public record PaymentDetailDto
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public AdvancePayment? AdvancePayment { get; set; }
    }
}
