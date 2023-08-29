using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data.Base;
using MoviesWebApp.Models;

namespace MoviesWebApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(MovieAppDbContext context) : base(context) { }
        
        // All below is commented out because the above line is contstructor for ActorsService
        // Which just takes in the context which is then passed to the base class generic constructor.

        //private readonly MovieAppDbContext _context;
        //public ActorsService(MovieAppDbContext context)
        //{
        //    _context = context; 
        //}
        //public async Task AddAsync(Actor actor)
        //{
        //    await _context.Actors.AddAsync(actor);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    _context.Actors.Remove(result);
        //    await _context.SaveChangesAsync();
        //}


        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync();
        //    return newActor;
        //}
    }
}
