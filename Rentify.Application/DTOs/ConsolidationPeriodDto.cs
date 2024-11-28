namespace Rentify.Application.DTOs
{
    public record ConsolidationPeriodDto
    {
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
