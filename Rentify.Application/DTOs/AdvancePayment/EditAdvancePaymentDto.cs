using Rentify.Application.DTOs.AdvancePaymentDetail;

namespace Rentify.Application.DTOs.AdvancePayment
{
    public record EditAdvancePaymentDto
    {
        public DateOnly PaymentDate { get; set; }
        public required ICollection<AdvancePaymentDetailDto> AdvancePaymentDetails { get; set; }
    }
}
