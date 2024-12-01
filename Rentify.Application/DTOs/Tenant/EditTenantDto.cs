namespace Rentify.Application.DTOs.Tenant
{
    public record EditTenantDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string ContactNumber { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
