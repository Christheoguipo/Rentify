using Rentify.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(75, ErrorMessage = "Username is too long.")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public required string Lastname { get; set;}
    }
}
