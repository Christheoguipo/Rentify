using Rentify.Domain.Entities.AdvancePayments;

namespace Rentify.Application.DTOs
{
    public record AdvancePaymentDto
    {
        public DateOnly PaymentDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public bool IsConsumed { get; set; }

        public required ICollection<AdvancePaymentDetail> AdvancePaymentDetails { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
