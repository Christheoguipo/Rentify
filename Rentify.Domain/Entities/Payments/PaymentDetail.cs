using Rentify.Domain.Entities.AdvancePayments;
using Rentify.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities.Payments
{
    public class PaymentDetail
    {
        public PaymentType PaymentType { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Invalid Amount.")]
        public decimal Amount { get; set; }


        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string? Description { get; set; }

        public AdvancePayment? AdvancePayment { get; set; }
    }
}
