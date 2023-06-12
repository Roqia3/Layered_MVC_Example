using MVC_Example.DataAccessLayer.Models;
using MVC_Example.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICountryService : ICrudService<CountryDto>
    {
        Task<List<CountryDto>> GetCountriesByRegion(string region);
    }
}
