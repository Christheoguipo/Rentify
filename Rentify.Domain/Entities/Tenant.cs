using Rentify.Domain.Common;
using Rentify.Domain.Entities.AdvancePayments;
using Rentify.Domain.Entities.Invoices;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class Tenant: BaseEntity
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(75, ErrorMessage = "First Name is too long.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage ="Last Name is required.")]
        [StringLength(75, ErrorMessage = "Last Name is too long.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Contact Number is required.")]
        public required string ContactNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email address.")]
        public string? Email { get; set; }

        public required ICollection<Room> Rooms { get; set; }
        public ICollection<Invoice>? Invoices { get; set; }
        public ICollection<AdvancePayment>? AdvancePayments { get; set; }
    }
}
