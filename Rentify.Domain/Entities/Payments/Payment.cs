using Rentify.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities.Payments
{
    public class Payment : BaseEntity
    {
        [Required]
        public DateOnly PaymentDate { get; set; }

        [Required]
        public decimal AmountPaid { get; set; }

        public Guid? ConsolidationPeriodId { get; set; }

        public required ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
