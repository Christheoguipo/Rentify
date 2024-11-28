using Rentify.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Application.DTOs
{
    public record RoomDto
    {
        public int RoomNumber { get; set; }
        public string? RoomName { get; set; }
        public decimal MonthlyCost { get; set; }
        public RoomStatus Status{ get; set; } = RoomStatus.Vacant;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
