﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystemV2.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Navn")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

    }