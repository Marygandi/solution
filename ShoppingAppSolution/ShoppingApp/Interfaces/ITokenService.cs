
    using ShoppingApp.Services;
    using ShoppingApp.Models.DTOs;
 
    namespace ShoppingAppApp.Interfaces
    {
        public interface ITokenService
        {
            string GetToken(UserDTO user);
        }
    }

