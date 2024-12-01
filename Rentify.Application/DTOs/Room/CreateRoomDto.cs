using Rentify.Domain.Common.Enums;

namespace Rentify.Application.DTOs.Room
{
    public record CreateRoomDto
    {
        public int RoomNumber { get; set; }
        public string? RoomName { get; set; }
        public decimal MonthlyCost { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Vacant;
    }
}
