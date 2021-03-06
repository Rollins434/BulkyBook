﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Category Name")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
