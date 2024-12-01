using Rentify.Domain.Entities;

namespace Rentify.Application.DTOs
{
    public record ConsolidationPeriodDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public User? ModifiedBy { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
    }
}
