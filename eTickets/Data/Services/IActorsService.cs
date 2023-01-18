using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService //add new item interface (this is an interface)
    {
        IEnumerable<Actor> GetAll(); //used to get all actors from the database  ___ strucutured like this -> return type, method name, and parameters if we have
        Actor GetById(int id); //return a single actor 
        void Add(Actor actor); //add data to the database so we will not return anything to the user 
        Actor Update(int id, Actor newActor); //functionality to update data in the database
        void Delete(int id); //functionality to delete data
    }
}
