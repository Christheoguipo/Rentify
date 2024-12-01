using Rentify.Domain.Common.Enums;

namespace Rentify.Application.DTOs.PaymentDetail
{
    public record PaymentDetailDto
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; } 
    }
}
