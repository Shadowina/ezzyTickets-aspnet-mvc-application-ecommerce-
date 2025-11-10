using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ezzyTickets.Data.Base;
using ezzyTickets.Data.Enums;

namespace ezzyTickets.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public double Price { get; set; }

        public string ImageURL { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate{ get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship

        public List<Actor_Movie> Actors_Movies { get; set; } = new();

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; } = null!;

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; } = null!;
    }
}
