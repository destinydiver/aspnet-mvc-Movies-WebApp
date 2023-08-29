using MoviesWebApp.Data.Base;
using MoviesWebApp.Models;

namespace MoviesWebApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(MovieAppDbContext context) : base(context) { }
    }
}
