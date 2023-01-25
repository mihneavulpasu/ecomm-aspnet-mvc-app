using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        public int Id { get; set; }

        
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 3 and 100 chars")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "A description is required")]
        public string? Description { get; set; }

        //Relationships
        public List<Movie>? Movies{ get; set; } //a cinema can have multiple movies
    }
}
