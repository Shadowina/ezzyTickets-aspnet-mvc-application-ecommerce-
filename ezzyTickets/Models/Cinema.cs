using System.ComponentModel.DataAnnotations;
using ezzyTickets.Data.Base;

namespace ezzyTickets.Models
{
    public class Cinema:IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage ="Cinema logo is required")]
        public string Logo { get; set; } = string.Empty;

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; } = string.Empty;

        //Relationship
        public List<Movie> Movies { get; set; } = new();
    }
}
