using MVC_Example.DataAccessLayer.Models;
using MVC_Example.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IUserService : ICrudService<UserDto>
    {
        // Add any additional methods specific to the User entity if needed
        Task SendWelcomeEmail(UserDto userDto);
    }
}
