namespace Rentify.Application.DTOs
{
    public record EditUserDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string Lastname { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
