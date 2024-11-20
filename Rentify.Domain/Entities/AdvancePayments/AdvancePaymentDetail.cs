using Rentify.Domain.Enums;

namespace Rentify.Domain.Entities.AdvancePayments
{
    public class AdvancePaymentDetail
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
