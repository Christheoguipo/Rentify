﻿using Rentify.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public required User CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public User? ModifiedBy { get; set; }
    }
}
