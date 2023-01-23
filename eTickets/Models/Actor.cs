using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")] //this makes the field obligatory and also gives an optional error message to the user
        public string? ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "A full name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 100 chars")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "A biography is required")]
        public string? Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; } //an actor can have multiple movies -> linked by Actors_Movies
                                                              //made this shit nullable for the create actor to work for some reason this was
                                                              //the whole problem
                                                              //another fix might be also to CTRL F then Current project then <Nullable>enable</Nullable> and delete that line from eTickets.
    }
}
