﻿using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class MonthlySummaryByTenant
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }

        [Range(1, 12)]
        public int Month { get; set; }
        public required Tenant Tenant { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal OutstandingBalance { get; set; }
    }
}
