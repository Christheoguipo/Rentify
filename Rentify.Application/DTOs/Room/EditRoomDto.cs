using Rentify.Application.DTOs.Tenant;
using Rentify.Domain.Common.Enums;

namespace Rentify.Application.DTOs.Room
{
    public record EditRoomDto
    {
        public int RoomNumber { get; set; }
        public string? RoomName { get; set; }
        public decimal MonthlyCost { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Vacant;
        public bool IsActive { get; set; } = true;


        public TenantDto? Tenant { get; set; }
    }
}
