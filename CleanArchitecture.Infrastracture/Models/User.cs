﻿using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Infrastracture.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public DateTime RegistrationDate { get; set; }

        public List<Borrowing>? Borrowings { get; set; }
    }
}
