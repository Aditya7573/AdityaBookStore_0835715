﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdityaBooks.Models
{
   public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
    }
}
