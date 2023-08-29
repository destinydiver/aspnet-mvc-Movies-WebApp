using MoviesWebApp.Data.Base;
using MoviesWebApp.Models;

namespace MoviesWebApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(MovieAppDbContext context) : base(context) { }      
    }
}
