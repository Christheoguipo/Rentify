using Rentify.Domain.Entities.Payments;

namespace Rentify.Application.DTOs
{
    public record PaymentDto
    {
        public DateOnly PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public Guid? ConsolidationPeriodId { get; set; }

        public required ICollection<PaymentDetail> PaymentDetails { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
