using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()  //add new item interface (this is an interface)
    {
        IEnumerable<T> GetAll(); //copy pasted everything here from IActorsService 
                                    //used to get all actors from the database  ___ strucutured like this -> return type, method name, and parameters if we have
        T GetById(int id);  //return a single actor
        void Add(T entity); //add data to the database so we will not return anything to the user 
        void Update(int id, T entity);  //functionality to update data in the database
        void Delete(int id); //functionality to delete data
    }
}
