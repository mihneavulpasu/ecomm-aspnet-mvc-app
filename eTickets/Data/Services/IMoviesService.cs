using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie> //also inherit in the movie model to remove error
    {
        Task<Movie> GetMovieById(int id);
    }
}
