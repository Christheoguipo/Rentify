using Rentify.Domain.Common;

namespace Rentify.Domain.Entities
{
    public class AdvancePayment : BaseEntity
    {
        public DateOnly PaymentDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public bool IsConsumed { get; set; }

        public required Guid TenantId { get; set; }
        public required ICollection<AdvancePaymentDetail> AdvancePaymentDetails { get; set; }
    }
}
