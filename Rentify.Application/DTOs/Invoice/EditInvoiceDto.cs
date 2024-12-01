using Rentify.Application.DTOs.InvoiceDetail;
using Rentify.Application.DTOs.Tenant;

namespace Rentify.Application.DTOs.Invoice
{
    public record EditInvoiceDto
    {
        public DateOnly InvoiceDate { get; set; }
        public DateOnly DueDate { get; set; }
         

        public required TenantDto Tenant { get; set; }
        public required ICollection<InvoiceDetailDto> InvoiceDetails { get; set; }
    }
}
