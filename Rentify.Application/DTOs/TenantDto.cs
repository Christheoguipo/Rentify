using Rentify.Domain.Entities;
using Rentify.Domain.Entities.AdvancePayments;
using Rentify.Domain.Entities.Invoices;

namespace Rentify.Application.DTOs
{
    public record TenantDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string ContactNumber { get; set; }
        public string? Email { get; set; }

        public required ICollection<Room> Rooms { get; set; }
        public ICollection<Invoice>? Invoices { get; set; }
        public ICollection<AdvancePayment>? AdvancePayments { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
