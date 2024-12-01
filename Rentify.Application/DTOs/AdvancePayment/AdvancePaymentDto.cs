using Rentify.Application.DTOs.AdvancePaymentDetail;
using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs.AdvancePayment
{
    public record AdvancePaymentDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public User? ModifiedBy { get; set; }

        public DateOnly PaymentDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public bool IsConsumed { get; set; }

        public required Guid TenantId { get; set; }
        public required ICollection<AdvancePaymentDetailDto> AdvancePaymentDetails { get; set; }
    }
}
