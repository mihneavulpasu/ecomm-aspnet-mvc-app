namespace eTickets.Models
{
    // makes the connection 
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; } //Actors_Movie can have a single Movie
        public int ActorId { get; set; }
        public Actor Actor { get; set; } //Actors_Movie can have a single Actor
    }
}
