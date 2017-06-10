﻿using CarRentalSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models.Cars
{
    public class CreateCarModel
    {
        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(1990, 2050)]
        public int Year { get; set; }

        public string Color { get; set; }

        public double Engine { get; set; }

        [Display(Name = "Engine Type")]
        [ScaffoldColumn(false)]
        public EngineType EngineType { get; set; }

        public int? Power { get; set; }

        [Display(Name = "Price in BGN per day")]
        public decimal PricePerDay { get; set; }

        [Required]
        [Url]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}