using Rentify.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class InvoiceDetail
    {
        [Required]
        public required ChargeType ChargeType { get; set; }

        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string? Description { get; set; }
        public decimal Amount { get; set; }


        public Room? Room { get; set; }
    }
}