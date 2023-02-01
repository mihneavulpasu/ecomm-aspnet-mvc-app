using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie> //also inherit in the movie model to remove error
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues(); //for the dropdowns thing when creating

        Task AddNewMovieAsync(newMovieVM data); //add movie to database

        Task UpdateMovieAsync(newMovieVM data);
    }
}
