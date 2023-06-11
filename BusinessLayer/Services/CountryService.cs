using MVC_Example.DataAccessLayer.Models;
using MVC_Example.DataAccessLayer.Repositories;
using MVC_Example.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Example.BusinessLayer.Services
{
    public class CountryService : BaseCrudService<CountryDto, Country>
    {
        public CountryService(IRepository<Country> repo) : base(repo)
        {
        }

        protected override Country MapToModel(CountryDto countryDto)
        {
            return new Country
            {
                Id = countryDto.Id,
                Name = countryDto.Name,
                Code = countryDto.Code
            };
        }

        protected override CountryDto MapToDto(Country country)
        {
            return new CountryDto
            {
                Id = country.Id,
                Name = country.Name,
                Code = country.Code
            };
        }

        protected override List<CountryDto> MapToDtoList(List<Country> list)
        {
            return list.Select(c => new CountryDto
            {
                Id = c.Id,
                Name = c.Name,
                Code = c.Code
            }).ToList();
        }
    }
}
