﻿using Rentify.Domain.Common;
using Rentify.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Rentify.Domain.Entities
{
    public class Room: BaseEntity
    {
        [Required]
        public int RoomNumber { get; set; }

        [StringLength(50, ErrorMessage = "Room Name is too long.")]
        public string? RoomName { get; set; }

        public decimal MonthlyCost { get; set; }

        public RoomStatus Status{ get; set; } = RoomStatus.Vacant;
    }
}
