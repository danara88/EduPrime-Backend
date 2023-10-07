﻿using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class RegisterUserDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}