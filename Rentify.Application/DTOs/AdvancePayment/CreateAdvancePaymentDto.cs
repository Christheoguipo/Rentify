using Rentify.Application.DTOs.AdvancePaymentDetail;

namespace Rentify.Application.DTOs.AdvancePayment
{
    public record CreateAdvancePaymentDto
    {
        public DateOnly PaymentDate { get; set; }
        public required Guid TenantId { get; set; }
        public required ICollection<AdvancePaymentDetailDto> AdvancePaymentDetails { get; set; }
    }
}
