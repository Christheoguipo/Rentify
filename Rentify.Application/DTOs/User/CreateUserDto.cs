namespace Rentify.Application.DTOs
{
    public record CreateUserDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string Lastname { get; set; }
    }
}
