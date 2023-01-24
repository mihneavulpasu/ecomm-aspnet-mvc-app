using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService: IEntityBaseRepository<Actor> //we inherit and use the Actor model
    {
    }
}
