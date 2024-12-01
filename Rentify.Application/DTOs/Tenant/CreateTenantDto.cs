namespace Rentify.Application.DTOs.Tenant
{
    public record CreateTenantDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string ContactNumber { get; set; }
        public string? Email { get; set; } 
    }
}
