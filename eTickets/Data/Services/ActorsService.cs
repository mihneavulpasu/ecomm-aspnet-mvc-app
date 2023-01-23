using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService //we are not using the controller to get all the data we are using the service now 
    {
        private readonly AppDbContext _context; 

        public ActorsService(AppDbContext context)
        {
                _context= context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _context.Actors.FirstOrDefault(x => x.Id == id);
            _context.Actors.Remove(result);
            _context.SaveChanges();
        }

        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor GetById(int id)
        {
            var result = _context.Actors.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            _context.Actors.Update(newActor);
            _context.SaveChanges();
            return newActor;
        }
    }
}
