using BusinessLayer.Services;
using MVC_Example.DataAccessLayer.Models;
using MVC_Example.DataAccessLayer.Repositories;
using MVC_Example.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Services.Email;


namespace MVC_Example.BusinessLayer.Services
{
    public abstract class BaseCrudService<TDto, TModel> : ICrudService<TDto> where TModel : BaseEntity where TDto : BaseDto
    {
        private IRepository<TModel> repo;

        public BaseCrudService(IRepository<TModel> repo)
        {
            this.repo = repo;
        }
        public virtual async Task CreateAsync(TDto userDto)
        {
            TModel user = MapToModel(userDto);

            //do logic here

            await repo.CreateAsync(user);

            //do logic here
        }

        protected abstract TModel MapToModel(TDto dto);

        public virtual async Task UpdateAsync(TDto userDto)
        {
            var user = MapToModel(userDto);

            await repo.UpdateAsync(user);

        }

        public virtual async Task DeleteAsync(TDto userDto)
        {
            var user = MapToModel(userDto);

            await repo.RemoveAsync(user);
        }

        public virtual async Task<List<TDto>> GetAsync()
        {
            var data = await repo.GetAll();

            List<TDto> dataDto = MapToDtoList(data);

            return dataDto;
        }

        protected abstract List<TDto> MapToDtoList(List<TModel> data);

        public virtual async Task<TDto> GetAsync(int id)
        {
            var model = await repo.GetById(id);

            TDto dto = MapToDto(model);

            return dto;
        }

        protected abstract TDto MapToDto(TModel model);
    }
}
