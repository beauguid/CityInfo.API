﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(50,ErrorMessage = "Name must be less than 50 characters in length!")]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
