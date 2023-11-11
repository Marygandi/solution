
using FeedbackGenerationApp.Models.DTOs;

namespace FeedbackGenerationApp.Interfaces
{
    public interface IUserService
    {
        UserDTO Login(UserDTO userDTO);
        UserDTO Register(UserDTO userDTO);
    }
}