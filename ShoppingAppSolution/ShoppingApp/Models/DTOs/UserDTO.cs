using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ShoppingApp.Models.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string? Username { get; set; }

        public string? Role { get; set; }
        public string? Token { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        public string? Password { get; set; }
        public ClaimsIdentity? Email { get; internal set; }
    }
}
