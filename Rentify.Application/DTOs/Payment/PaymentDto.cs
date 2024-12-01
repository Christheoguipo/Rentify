using Rentify.Application.DTOs.PaymentDetail;
using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs.Payment
{
    public record PaymentDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public User? ModifiedBy { get; set; }
        public DateOnly PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public Guid? ConsolidationPeriodId { get; set; }


        public required ICollection<PaymentDetailDto> PaymentDetails { get; set; }
    }
}
