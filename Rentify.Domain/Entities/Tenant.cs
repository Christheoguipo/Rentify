using Rentify.Domain.Common;
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
        public bool IsActive { get; set; } = true;


        public ICollection<Room>? Rooms { get; set; }
    }
}
