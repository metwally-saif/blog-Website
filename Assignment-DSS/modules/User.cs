﻿using System.ComponentModel.DataAnnotations;

namespace Assignment_DSS.modules
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Password { get; set; }
        
        

    }
}
