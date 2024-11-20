using Rentify.Domain.Common;

namespace Rentify.Domain.Entities
{
    public class ConsolidationPeriod: BaseEntity
    {
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
    }
}
