﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(13, ErrorMessage = "First Name is too Long")]
        [MinLength(5, ErrorMessage = "First Name is too  short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "Last Name is too Long")]
        [MinLength(5, ErrorMessage = "Last Name is too  short")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
