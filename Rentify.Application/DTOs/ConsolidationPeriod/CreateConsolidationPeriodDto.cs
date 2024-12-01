namespace Rentify.Application.DTOs.ConsolidationPeriod
{
    public record CreateConsolidationPeriodDto
    {
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
    }
}
