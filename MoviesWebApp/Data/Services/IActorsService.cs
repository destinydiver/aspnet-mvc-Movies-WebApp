using MoviesWebApp.Data.Base;
using MoviesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
        // Below is commented out now that IActorService inherits from IEntityBaseRepository

        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);
        //Task DeleteAsync(int id);
    }
}
