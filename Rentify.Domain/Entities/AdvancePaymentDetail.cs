using Rentify.Domain.Common.Enums;

namespace Rentify.Domain.Entities
{
    public class AdvancePaymentDetail
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
