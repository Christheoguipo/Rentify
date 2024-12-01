namespace Rentify.Application.DTOs
{
    public record UserDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required UserDto CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public UserDto? ModifiedBy { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string Lastname { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
