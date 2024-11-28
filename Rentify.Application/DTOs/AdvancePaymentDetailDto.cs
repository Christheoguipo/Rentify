using Rentify.Domain.Common.Enums;

namespace Rentify.Application.DTOs
{
    public record AdvancePaymentDetailDto
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
