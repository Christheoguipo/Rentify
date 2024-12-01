using Rentify.Application.DTOs.PaymentDetail;

namespace Rentify.Application.DTOs.Payment
{
    public record CreatePaymentDto
    { 
        public DateOnly PaymentDate { get; set; }

        public required ICollection<PaymentDetailDto> PaymentDetails { get; set; }
    }
}
