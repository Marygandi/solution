﻿using ShoppingApp1.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp1.Models.DTOs
{
    public class UserViewModel : UserDTO
    {
        [Required(ErrorMessage = "Re type password cannot be empty")]
        [Compare("Password", ErrorMessage = "Password and retype password do not match")]
        public string ReTypePassword { get; set; }
    }
}