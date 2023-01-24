using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService //we are not using the controller to get all the data we are using the service now 
    {
        public ActorsService(AppDbContext context) : base(context) { }
    } // we deleted everything as we are inheriting from the base
}
