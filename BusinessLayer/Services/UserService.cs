using MVC_Example.BusinessLayer.Services;
using MVC_Example.DataAccessLayer.Models;
using MVC_Example.DataAccessLayer.Repositories;
using MVC_Example.Dtos;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : BaseCrudService<UserDto,User>
    {
        public UserService(IRepository<User> repo) : base(repo)
        {
        }

        protected override User MapToModel(UserDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                SecondName = userDto.SecondName,
                Email = userDto.Email,
                CreatedDate = userDto.CreatedDate,
            };
        }
        protected override UserDto MapToDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                CreatedDate = user.CreatedDate,
                Email = user.Email,
            };
        }

        protected override List<UserDto> MapToDtoList(List<User> list)
        {
            return list.Select(t => new UserDto
            {
                Id = t.Id,
                FirstName = t.FirstName,
                SecondName = t.SecondName,
                Email = t.Email,
                CreatedDate = t.CreatedDate,
            }).ToList();
        }
    }
}
