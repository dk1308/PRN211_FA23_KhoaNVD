﻿using System.ComponentModel.DataAnnotations;

namespace Demo_01.Models.DTOs
{
    public class AddWalkRequestDTO
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be maximum of 100 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage = "Description has to be maximum of 1000 characters")]
        public string Description { get; set; }
        [Required]
        [Range(0,100)]
        public double LengthInKm { get; set; }
        public string? WalkImageURL { get; set; }
        [Required]
        public Guid DifficultyId { get; set; }
        [Required]
        public Guid RegionId { get; set; }
    }
}
