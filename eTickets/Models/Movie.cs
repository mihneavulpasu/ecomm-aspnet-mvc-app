using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie:IEntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; } //a movie can have multiple actors -> linked by Actors_Movies

        //Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; } //Movies can have a single Cinema

        //Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; } //Movies can have a single Producer
    }
}
