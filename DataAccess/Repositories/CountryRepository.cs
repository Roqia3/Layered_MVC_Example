using MVC_Example.DataAccessLayer.Models;

namespace MVC_Example.DataAccessLayer.Repositories
{
    public class CountryRepository : BaseRepository<Country>
    {
        public CountryRepository(YourDbContext dbContext) : base(dbContext)
        {
        }
    }
}
