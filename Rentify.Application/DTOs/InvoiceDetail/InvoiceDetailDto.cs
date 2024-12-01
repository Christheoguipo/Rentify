using Rentify.Application.DTOs.Room;
using Rentify.Domain.Common.Enums;

namespace Rentify.Application.DTOs.InvoiceDetail
{
    public record InvoiceDetailDto
    {
        public required ChargeType ChargeType { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }


        public RoomDto? Room { get; set; }
    }
}
