using Rentify.Application.DTOs.Room;

namespace Rentify.Application.DTOs.Tenant
{
    public record TenantDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required UserDto CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public UserDto? ModifiedBy { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string ContactNumber { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;


        public required ICollection<RoomDto> Rooms { get; set; }
    }
}
