﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CrateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Adress Is Too Long")]
        public string Adress { get; set; }
        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
    public class HotelDTO : CrateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
