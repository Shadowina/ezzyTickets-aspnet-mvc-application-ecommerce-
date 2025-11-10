using System.ComponentModel.DataAnnotations;
using ezzyTickets.Data.Base;

namespace ezzyTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; } = string.Empty;

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; } = string.Empty;

        //Relationship

        public List<Actor_Movie> Actors_Movies { get; set; } = new();


    }
}
