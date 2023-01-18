using eTickets.Models;

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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
